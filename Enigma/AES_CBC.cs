using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Enigma
{

    //AES-CBC encryption class by jonas
    class AES_CBC
    {
        private AesCryptoServiceProvider cryptoServiceProvider;

        //Constructor
        public AES_CBC()
        {
            cryptoServiceProvider = new AesCryptoServiceProvider();

            //set Block and keysize, generate IV and Key, set CBC mode and Padding Mode
            cryptoServiceProvider.BlockSize = 128;
            cryptoServiceProvider.KeySize = 256;
            cryptoServiceProvider.GenerateIV();
            cryptoServiceProvider.GenerateKey();
            cryptoServiceProvider.Mode = CipherMode.CBC;
            cryptoServiceProvider.Padding = PaddingMode.PKCS7;
        }

        //Functions

        //Encryption Function, encrypts text
        //Takes inputText as paramenter
        public string Encrypt(string plainText)
        {
            //Create Encryptor
            ICryptoTransform cryptoTransform = cryptoServiceProvider.CreateEncryptor();

            byte[] encrypted_bytes = cryptoTransform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(plainText), 0, plainText.Length);

            string str = Convert.ToBase64String(encrypted_bytes);
            return str;
        }

        public byte EncryptImage (byte[] inputImage)
        {
            ICryptoTransform cryptoTransform = cryptoServiceProvider.CreateEncryptor();

            byte[] encryptedImage = cryptoTransform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(inputImage, 0, inputImage.Length));

            return encryptedImage;
        }

        //Decryption Function, decrypts text
        //Takes inputText as parameter
        public string Decrypt(string encryptedText)
        {
            //Create Decryptor
            ICryptoTransform cryptoTransform = cryptoServiceProvider.CreateDecryptor();

            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            byte[] decryptedBytes = cryptoTransform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

            string str = ASCIIEncoding.ASCII.GetString(decryptedBytes);

            return str;
        }

        public byte DecryptImage(byte[] encryptedImage)
        {
            ICryptoTransform cryptoTransform = cryptoServiceProvider.CreateDecryptor();

            byte[] encryptedBytes = Convert.FromBase64String(encryptedImage);

            byte[] decryptedBytes = cryptoTransform.TransformFinalBlock(encryptedImage, 0, encryptedImage.Length);

            return decryptedBytes;
        }
    }
}
