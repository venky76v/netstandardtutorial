using System;

namespace netstandardclasslibrary
{
    public static class StringLib
    {
        public static bool StartsWithUpper(this string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            char ch = str[0];

            return Char.IsUpper(ch);
        }

        public static bool StartsWithLower(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            Char ch = str[0];
            return Char.IsLower(ch);
        }

        public static bool StartsWithNumber(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            Char ch = str[0];
            return Char.IsNumber(ch);
        }
    }
}
