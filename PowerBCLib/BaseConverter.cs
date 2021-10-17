using System;
using System.Collections.Generic;

namespace PowerBCLib
{
    public class BaseConverter
    {
        private static char[] chars = new char[] { '0','1','2','3','4','5','6','7','8','9',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x', 'y', 'z'};
        public const int MAX_RADIX = 32;
        public string NumToStr(ulong value, ulong targetBase)
        {
            string result = string.Empty;
            do
            {
                result = chars[value % targetBase] + result;
                value /= targetBase;
            }
            while (value > 0);

            return result;
        }

        /// <summary>
        /// An optimized method using an array as buffer instead of 
        /// string concatenation. This is faster for return values having 
        /// a length > 1.
        /// </summary>
        public string NumToStrFast(ulong value, ulong targetBase)
        {
            // 32 is the worst cast buffer size for base 2 and int.MaxValue
            int i = 32;
            char[] buffer = new char[i];

            do
            {
                buffer[--i] = chars[value % targetBase];
                value /= targetBase;
            }
            while (value > 0);

            char[] result = new char[32 - i];
            Array.Copy(buffer, i, result, 0, 32 - i);

            return new string(result);
        }


        public ulong? StrToNum(string value, ulong sourceBase)
        {
            if (string.IsNullOrWhiteSpace(value)) { return null; }
            try
            {
                var radix = (uint)sourceBase;
                var radixChars = new char[radix];
                Array.Copy(chars, 0, radixChars, 0, radix);
                var validChars = new string(radixChars);
                value = value.Trim();

                ulong result = 0;
                var lastIdx = value.Length - 1;
                for (int i = lastIdx; i >= 0; i--)
                {
                    var pos = validChars.IndexOf(value[i]); // == multiplier
                    if (pos < 0) { return null; }
                    var posVal = (double)(lastIdx - i);
                    result += checked((ulong)Math.Pow(sourceBase, (double)posVal) * (ulong)pos);
                }

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
