using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma
{

    public class Viginere : Substitution
    {

        public Viginere()
        {
        }

        //Class vars

        private StringBuilder encryption;
        private StringBuilder decryption;
        private char[] viginereAlphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        //Encryption method
        public string Encrypt(string inputText, string keyText)
        {
            //Vars
            string key = AdjustKeyLength(inputText, keyText);
            encryption = new StringBuilder();

            inputText = inputText.Replace(" ", "");
            keyText = keyText.Replace(" ", "");

            //Encryption magic
            for (int i = 0; i < inputText.Length; i++)
            {
                encryption.Append(viginereAlphabet[Modulo(Array.IndexOf(viginereAlphabet, inputText[i]) + Array.IndexOf(viginereAlphabet, key[i]), 26)]);
            }

            return encryption.ToString();
        }

        //Make key as long as input text
        public static string AdjustKeyLength(string inputText, string keystring)
        {

            StringBuilder key = new StringBuilder(keystring);
            while (inputText.Length > key.Length)
            {
                key.Append(keystring);
            }


            return key.ToString();
        }

        //Decryption method
        public string Decrypt(string encryptedText, string keyText)
        {
            //Vars
            string key = AdjustKeyLength(encryptedText, keyText);
            decryption = new StringBuilder();

            encryptedText = encryptedText.Replace(" ", "");
            keyText = keyText.Replace(" ", "");

            //Decryption magic
            for (int i = 0; i < encryptedText.Length; i++)
            {
                decryption.Append(viginereAlphabet[Modulo(Array.IndexOf(viginereAlphabet, encryptedText[i]) - Array.IndexOf(viginereAlphabet, key[i]), 26)]);
            }

            return decryption.ToString();
        }

        //Modulo Method
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
