using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;

namespace Enigma
{

    //AES-CBC encryption class by jonas
    class AES_CBC
    {
        private AesCryptoServiceProvider cryptoServiceProvider;
        private Image img = Image.FromFile("H:/C28E/Programmieren 3.5/Jonas Sobotta/Enigma/Enigma/image.png");



        //Constructor
        /*public AES_CBC()
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

        public string EncryptImage ()
        {
            ICryptoTransform cryptoTransform = cryptoServiceProvider.CreateEncryptor();

            

            byte[] encrypted_bytes = cryptoTransform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(img.ToString()), 0, img.ToString().Length);
            FileStream fs = File.OpenWrite();
            fs.Close();

            string str = Convert.ToBase64String(encrypted_bytes);
            return str;
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

        /*public byte[] DecryptImage(string encryptedImage)
        {
            ICryptoTransform cryptoTransform = cryptoServiceProvider.CreateDecryptor();

            byte[] decryptedBytes = cryptoTransform.TransformFinalBlock(encryptedImage, 0, encryptedImage.Length);

            return decryptedBytes;
        }*/
    }
}
