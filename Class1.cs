namespace StringExtensionsLibrary
{
    public static class Class1
    {
        /// <summary>
        /// Checks if a string starts with an uppercase letter.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>True if the string starts with an uppercase letter; otherwise, false.</returns>
        public static bool StartsWithUpperCase(this string str)
        {
            // Return false if the string is null or empty.
            if (string.IsNullOrEmpty(str)) return false;

            // Check if the first character is uppercase.
            return char.IsUpper(str[0]);
        }
    }
}
