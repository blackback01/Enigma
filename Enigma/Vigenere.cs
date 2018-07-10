using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma
{

    public class Viginere
    {

        public string Encrypt(string inputText, string keyText)
        {
            StringBuilder encryption = new StringBuilder();

            inputText = inputText.ToUpper();
            inputText = inputText.Replace(" ", "");
            keyText = keyText.ToUpper();
            keyText = keyText.Replace(" ", "");

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            string key = AdjustKeyLength(inputText, keyText);

            for (int i = 0; i < inputText.Length; i++)
            {
                encryption.Append(alphabet[Modulo(Array.IndexOf(alphabet, inputText[i]) + Array.IndexOf(alphabet, key[i]), 26)]);
            }

            return encryption.ToString();
        }


        public static string AdjustKeyLength(string inputText, string keystring)
        {
            StringBuilder key = new StringBuilder(keystring);

            while (inputText.Length > key.Length)
            {
                key.Append(keystring);
            }


            return key.ToString();
        }

        public string Decrypt(string encryptedText, string keyText)
        {

            encryptedText = encryptedText.ToUpper();
            encryptedText = encryptedText.Replace(" ", "");
            keyText = keyText.ToUpper();
            keyText = keyText.Replace(" ", "");

            StringBuilder encryption = new StringBuilder();
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string key = AdjustKeyLength(encryptedText, keyText);

            for (int i = 0; i < encryptedText.Length; i++)
            {
                encryption.Append(alphabet[Modulo(Array.IndexOf(alphabet, encryptedText[i]) - Array.IndexOf(alphabet, key[i]), 26)]);
            }

            return encryption.ToString();
        }


        public static int Modulo(int dividend, int divisor)
        {

            int rest = dividend % divisor;

            if (rest < 0)
            {

                return rest + divisor;
            }
            else
            {

                return rest;
            }
        }
    }
}
