using System;

namespace StringExtensionsLibrary
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if the string starts with an uppercase letter.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>True if the first character is uppercase; otherwise, false.</returns>
        public static bool StartsWithUpperCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            return char.IsUpper(input[0]);
        }
    }
}
