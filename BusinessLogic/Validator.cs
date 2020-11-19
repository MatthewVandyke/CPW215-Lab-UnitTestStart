using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {
        // Used regex found on stackoverflow
        public static Regex ssnRegex = new Regex(@"^(?!000)(?!666)(?!9[0-9][0-9])\d{3}[- ]?(?!00)\d{2}[- ]?(?!0000)\d{4}$");

        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            return ssnRegex.IsMatch(ssn);
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            return (numToTest >= minValue && numToTest <= maxValue);
        }
    }
}
