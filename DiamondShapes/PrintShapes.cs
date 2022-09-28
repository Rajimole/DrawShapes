using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace DiamondShapes
{
    public class PrintShapes : IPrintShapes
    {
        private const char firstLetter = 'A';
        private const string validationMsg = "Please enter only alphabet:";

        /// <summary>
        /// This function Prints Diamond shaped alphabet
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns>returns diamond shaped alphabets in string format</returns>
        public string PrintDiamond(char alphabet)
        {
            return DrawDiamond(alphabet);
        }

        /// <summary>
        /// This function returns validation message to input alphabet
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns>returns validation message string</returns>
        public string ShowValidationMessage(char alphabet)
        {
            if (!IsValidInput(alphabet))
            {
                return validationMsg;
            }
            return alphabet.ToString();
        }

        /// <summary>
        /// validates the Input against character
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns>returns true if valid</returns>
        public bool IsValidInput(char alphabet)
        {
            return char.IsLetter(alphabet);
        }

        /// <summary>
        /// Draw full diamond
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns>returns full diamond shaped alphabets in string format</returns>
        private string DrawDiamond(char alphabet)
        {
            int letterNumber;
            StringBuilder str = new StringBuilder();
            DrawUpperDiamond(alphabet, str, out letterNumber);
            DrawLowerDiamond(letterNumber, str);
            return str.ToString();
        }

        /// <summary>
        /// Draw upper half of diamond
        /// </summary>
        /// <param name="alphabet">Input letter</param>
        /// <param name="str">string that needs to be appended as we form the diamond</param>
        /// <param name="letterNumber">out parameter which has numbers of lines that needs iteration for the given alphabet</param>
        /// <returns>string diamond format</returns>
        private string DrawUpperDiamond(char alphabet, StringBuilder str, out int letterNumber)
        {
            int startLetter = (int)firstLetter;
            int endLetter = (int)char.ToUpper(alphabet);
            Console.WriteLine();
            letterNumber = endLetter - startLetter;
            string[] shape = new string[letterNumber + 1];
            int initialChar = startLetter;

            for (int i = 0; i <= letterNumber; i++)
            {
                for (int j = 0; j < letterNumber - i; j++)
                {
                    str.Append(" ");
                }
                char letter = (char)initialChar;
                str.Append(letter);
                if (letter != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        str.Append(" ");
                    }
                    str.Append(letter);
                }
                str.AppendLine();
                initialChar++;
            }

            return str.ToString();
        }

        /// <summary>
        /// Draw bottom part of diamond
        /// </summary>
        /// <param name="str">string that needs to be appended</param>
        /// <param name="letterNumber">parameter which has numbers of lines that needs iteration for the given alphabet</param>
        /// <returns>string diamond format</returns>

        private string DrawLowerDiamond(int letterNumber, StringBuilder str)
        {
            for (int i = letterNumber - 1; i >= 0; i--)
            {
                str.AppendLine(str.ToString().Split(Environment.NewLine)[i]);
            }

            return str.ToString();
        }

    }
}