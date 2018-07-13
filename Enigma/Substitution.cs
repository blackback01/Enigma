﻿using System;

namespace Enigma
{
    public class Substitution
    {
        protected int iKey;
        protected string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //Substitution
        public Substitution()
        {
        }
        //Encrypt
        public string Encrypt(string inputText)
        {
            int counter = 0;
            string outputText = "";
            foreach (char c in inputText)
            {
                if (alphabet.Contains(c.ToString()))
                {
                    int i = alphabet.IndexOf(c) + iKey;
                    if (i > 26)
                    {
                        i -= alphabet.Length;
                    }
                    if (char.IsUpper(c))
                    {
                        outputText = outputText + char.ToUpper(alphabet[i]).ToString();
                    } else
                    {
                        outputText = outputText + char.ToLower(alphabet[i]).ToString();
                    }
                } else
                {
                    outputText = outputText + c.ToString();
                }
                counter++;
            }
            return outputText;
        }
        //Decrypt
        public string Decrypt(string inputText)
        {
            int counter = 0;
            string outputText = "";
            foreach (char c in inputText)
            {
                if (alphabet.Contains(c.ToString()))
                {
                    int i = alphabet.IndexOf(c) - iKey;
                    if (i < 0)
                    {
                        i += alphabet.Length;
                    }
                    if (char.IsUpper(c))
                    {
                        outputText = outputText + char.ToUpper(alphabet[i]).ToString();
                    }
                    else
                    {
                        outputText = outputText + char.ToLower(alphabet[i]).ToString();
                    }
                } else
                {
                    outputText = outputText + c.ToString();
                }
                counter++;
            }
            return outputText;
        }
    }
}
