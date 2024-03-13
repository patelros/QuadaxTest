using System.Text;

namespace QuadaxTestApp
{
    public class RandomDigit
    {
        private static Random _random = new Random();
        private NumberToGuess _guess;
        private List<Rounds> _turn = new List<Rounds>();

        public RandomDigit() : this(GetDigit()) { }

        public RandomDigit(string code)
        {
            Code = code;
           _guess = new NumberToGuess(Code);
        }

        private static string GetDigit(int length = 4)
        {
            var randomDigits = Enumerable.Range(0, length)
            .Select(_ => _random.Next(1, 6).ToString());
            return string.Concat(randomDigits);
        }

        public string Code { get; set; }
        public bool IsFinished { get; private set; }

        public string Guess(string guess)
        {
            var turn = new Rounds
            {
                Number = _turn.Count + 1,
                Guess = guess,
                Response = _guess.Verification(guess)
            };
            _turn.Add(turn);

            if (turn.Response == "++++" || turn.Number > 9)
            {
                IsFinished = true;
                return turn.Response == "++++" ? $"Yay, you won!\n(in only {turn.Number})" : $"you lose.\n(the code was \"{Code}\")";
            }

            return turn.Response;
        }
    }

    public class Rounds
    {
        public int Number { get; set; }
        public string? Guess { get; set; }
        public string? Response { get; set; }
    }
}