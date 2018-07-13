using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PowerCrypt
{
    public class Viginere : Substitution
    {
        #region Declarations and variables
        private StringBuilder encryption;
        private StringBuilder decryption;
        private readonly char[] viginereAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789?!,.:()' ".ToCharArray();
        private double num;
        private bool isNum;
        #endregion
        //Encrypt
        public string Encrypt(string inputText, string keyText)
        {
            string key = AdjustKeyLength(inputText, keyText);
            encryption = new StringBuilder();
            isNum = double.TryParse(keyText, out num);
            if (isNum)
            {
                MessageBox.Show("Invailid Key, only letters from a - z are valid.");
                MessageBox.Show(viginereAlphabet.Length.ToString());
                return null;
            }

            

            //Encryption magic
            for (int i = 0; i < inputText.Length; i++)
            {
                encryption.Append(viginereAlphabet[Modulo(Array.IndexOf(viginereAlphabet, inputText[i]) + Array.IndexOf(viginereAlphabet, key[i]),71)]);
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
        //Decrypt
        public string Decrypt(string encryptedText, string keyText)
        {
            string key = AdjustKeyLength(encryptedText, keyText);
            decryption = new StringBuilder();
            //Invailed Key
            isNum = double.TryParse(keyText, out num);
            if (isNum)
            {
                MessageBox.Show("Invailid Key, only letters from a - z are valid.");
                return null;
            }
            //Decryption magic
            for (int i = 0; i < encryptedText.Length; i++)
            {
                decryption.Append(viginereAlphabet[Modulo(Array.IndexOf(viginereAlphabet, encryptedText[i]) - Array.IndexOf(viginereAlphabet, key[i]),71)]);
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
