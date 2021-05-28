using System;

namespace test
{
    class Program
    {
        public static void Main()
        {
            int myKey = 7;
            CaesarCipher hailCaesar = new CaesarCipher(myKey);
            string myMessage = "abcdefghijklmnopqrstuvwxyz!?.";
            string encryptedMessage = hailCaesar.Encrypt(myMessage);
            string decryptedMessage = hailCaesar.Decrypt(encryptedMessage);

            myMessage = "hello, world!";
            encryptedMessage = hailCaesar.Encrypt(myMessage);
            decryptedMessage = hailCaesar.Decrypt(encryptedMessage);
        }
    }

    class CaesarCipher
    {
        public int Key;

        public CaesarCipher(int key)
        {
            this.Key = key;
        }

        public string Encrypt(string message)
        {
            char[] charArr = message.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (char.IsLetter(charArr[i]))
                {
                    charArr[i] = (char)(((charArr[i] - 'a' + Key) % 26) + 'a');
                }
            }
            string str = new string(charArr);
            return str;
        }

        public string Decrypt(string secret)
        {
            char[] charArr = secret.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (char.IsLetter(charArr[i]))
                {
                    charArr[i] = (char)(((charArr[i] - 'a' - Key + 26) % 26) + 'a');
                }
            }
            string str = new string(charArr);
            return str;
        }
    }
}
