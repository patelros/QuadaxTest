using System.Text;

namespace QuadaxTestApp
{
    public class NumberToGuess
    {
        private string code;

        public NumberToGuess(string code)
        {
            this.code = code;
        }
        public string Verification(string guess)
        {
            return new string(guess.Select((digit, index) =>
            code.Contains(digit) ? code[index] == digit ? '+' : '-' : ' ').ToArray());
        }
    }
}