using System.Collections.Generic;

namespace FizzBuzz
{
    /// <summary>
    /// Class handling the FizzBuzz logic
    /// </summary>
    public static class FizzBuzzLogic
    {
        /// <summary>
        /// Method to run the FizzBuzz process for a given number of records
        /// </summary>
        /// <param name="numberOfResults">Number to count</param>
        /// <returns>IEnumerable of the output results</returns>
        public static IEnumerable<string> FizzBuzz(int numberOfResults = 10)
        {
            var results = new List<string>();

            for (int i = 1; i <= numberOfResults; i++)              // Notice .editorconfig complaint on int
                results.Add(Format(i));

            return results;
        }

        /// <summary>
        /// Method to convert a given number to the desired output
        /// </summary>
        /// <param name="number">Number to format</param>
        /// <returns>Formatted output result</returns>
        public static string Format(int number)
        {
            var result = number.ToString();

            if (number % 3 == 0 && number % 5 == 0)
                result = "FizzBuzz";
            else if (number % 3 == 0)
                result = "Fizz";
            else if (number % 5 == 0)
                result = "Buzz";
            else if (number.ToString().Contains("3") && number.ToString().Contains("5"))
                result = "FizzBuzz";
            else if (number.ToString().Contains("3"))
                result = "Fizz";
            else if (number.ToString().Contains("5"))
                result = "Buzz";

            return result;
        }
    }
}
