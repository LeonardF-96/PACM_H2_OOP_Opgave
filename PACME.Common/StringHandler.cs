using System;

namespace PACME.Common
{
    public static class StringHandler
    {
        //Inserts Spaces before each capital letter in a string.
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
