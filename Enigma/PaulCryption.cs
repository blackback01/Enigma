﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerCrypt
{
    class PaulCryption
    {
        Transposition transposition;
        Rot substitution;
        int key1;
        int key2;
        //Encrypt
        public string Encrypt(string inputText, int key)
        {
            key1 = key;
            key2 = (int)Math.Floor((double)(key1 * inputText.Length / 10));
            substitution = new Rot(key);
            transposition = new Transposition(key);
            string transText;
            string outputText;
            transText = substitution.Encrypt(inputText);
            outputText = transposition.Encrypt(transText);
            return outputText;
        }
        //Decrypt
        public string Decrypt(string inputText, int key)
        {
            key1 = key;
            key2 = (int)Math.Floor((double)(key1 * inputText.Length / 10));
            substitution = new Rot(key);
            transposition = new Transposition(key);
            string transText;
            string outputText;
            transText = substitution.Decrypt(inputText);
            outputText = transposition.Decrypt(transText);
            return outputText;
        }
    }
}
