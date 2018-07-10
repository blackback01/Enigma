using System;

namespace Enigma
{
    public class Substitution
    {
        int iKey;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        public Substitution()
        {
        }

        public string Encrypt(string inputText)
        {
            string outputText;
            foreach (char c in inputText)
            {
                if (alphabet.Contains(c))
                {
                    int i = alphabet.IndexOf(c) + iKey;
                    if (c.IsUpper())
                    {
                        outputText = outputText + alphabet[i].ToUpper();
                    } else
                    {
                        outputText = outputText + alphabet[i].ToLower();
                    }
                } else
                {
                    outputText = outputText + c;
                }
            }
            return outputText;
        }

        public void Decrypt(string inputText)
        {
            string outputText;
            foreach (char c in inputText)
            {
                if (alphabet.Contains(c))
                {
                    int i = alphabet.IndexOf(c) + iKey;
                    if (c.IsUpper())
                    {
                        outputText = outputText + alphabet[i].ToUpper();
                    }
                    else
                    {
                        outputText = outputText + alphabet[i].ToLower();
                    }
                } else
                {
                    outputText = outputText + c;
                }
            }
        }
    }
}
