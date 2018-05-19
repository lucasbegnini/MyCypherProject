using PlayFairDecipher.src;

namespace MyCypherWork
{
    class MyCypher
    {
        private static int cesarKey = 10;
        private static int numberOfEncipher = 2;
        private static string playerFairKey = "vareta";
        private static string Cipher(string input, bool encipher)
        {
            string aux = string.Empty;
            string retVal = string.Empty;

            CesarCypher _cesar = new CesarCypher();
            PlayFair _playerFair = new PlayFair();
            if (encipher)
            {
                for (int i = 0; i < numberOfEncipher; i++)
                {
                    aux = _cesar.Encipher(input, cesarKey);
                    aux = _playerFair.Encipher(input, playerFairKey);
                }
            }
            else
            {
                for (int i = 0; i < numberOfEncipher; i++)
                {
                    aux = _cesar.Decipher(input, cesarKey);
                    aux = _playerFair.Decipher(input, playerFairKey);
                }
            }
            retVal = aux;
            return retVal;
        }
        public string Encipher(string input)
        {
            return Cipher(input, true);
        }

        public string Decipher(string input)
        {
            return Cipher(input, false);
        }
    }
}
