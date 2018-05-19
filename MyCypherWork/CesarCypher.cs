using System;

namespace MyCypherWork
{
    class CesarCypher
    {
        private static string Cipher(string input, bool encipher,int cesarKey)
        {
            string retVal = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int ASCII = (int)input[i];
                int ASCIIC;

                if (encipher)
                {
                    ASCIIC = ASCII - cesarKey;
                }
                else
                {
                    ASCIIC = ASCII + cesarKey;
                }
                retVal += Char.ConvertFromUtf32(ASCIIC);
            }
            return retVal;
        }
        public string Encipher(string input, int cesarKey)
        {
            return Cipher(input, true,cesarKey);
        }

        public string Decipher(string input, int cesarKey)
        {
            return Cipher(input, false, cesarKey);
        }
    }
}
