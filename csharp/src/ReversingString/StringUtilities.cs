using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public string Reverse(string s)
        {
            char[] stringToCharacters = s.ToCharArray(); // Get input from user and split into chars
            return ReverseOptimal(stringToCharacters);
        }

        private static string ReverseOptimal(char[] input) // Built in function to reverse characters and simply returning it
        {
            Array.Reverse(input);
            string output = new string(input);

            return output;
        }

        private static string ReverseStringStrategy1(char[] input) // incrementing a string with a decrementing chars index
        {
            string reversedString = "";

            for(int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i].ToString();
            }

            string output = new string(reversedString);

            return output;
        }
    }
}
