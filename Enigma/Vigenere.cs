using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        private readonly char[] viginereAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789?!,.:()' ".ToCharArray();
        private double num;
        private bool isNum;

        //Encryption method
        public string Encrypt(string inputText, string keyText)
        {
            //Vars
            string key = AdjustKeyLength(inputText, keyText);
            encryption = new StringBuilder();

            //inputText = inputText.ToLower();

            //Invailed key?
            isNum = double.TryParse(keyText, out num);

            
            if (isNum) {
                MessageBox.Show("Invailid Key, use only letters from a - z");
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

        //Decryption method
        public string Decrypt(string encryptedText, string keyText)
        {
            //Vars
            string key = AdjustKeyLength(encryptedText, keyText);
            decryption = new StringBuilder();

            //encryptedText = encryptedText.ToLower();

            //Invailed Key
            isNum = double.TryParse(keyText, out num);

            if (isNum)
            {
                MessageBox.Show("Invailid Key, use only letters from a - z");
                return null;
            }

            //Decryption magic
            for (int i = 0; i < encryptedText.Length; i++)
            {
                decryption.Append(viginereAlphabet[Modulo(Array.IndexOf(viginereAlphabet, encryptedText[i]) - Array.IndexOf(viginereAlphabet, key[i]),71)]);
            }

            return decryption.ToString();

            /*
             hello hi i am so cool and say me fucking program why dont you work like i want you to work i am so angry at you fuck it all fuck it all i dont give a shit anymore 1234567890
             */
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
