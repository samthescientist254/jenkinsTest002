using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace TransactionDataApiSettlement.Security
{
    public class SecureData
    {

        public string Encrypt(string textToEncrypt, string key)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 0x80;
            rijndaelCipher.BlockSize = 0x80;
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[0x10];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }
            Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes;
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);
            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
        }

        public string Decrypt(string textToDecrypt, string key)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 0x80;
            rijndaelCipher.BlockSize = 0x80;
            byte[] encryptedData = Convert.FromBase64String(textToDecrypt);
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[0x10];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }
            Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes;
            byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText);
        }

        static void EncryptTextRSA(string publicKey, string text, string fileName)
        {
            // Convert the text to an array of bytes   
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = byteConverter.GetBytes(text);

            // Create a byte array to store the encrypted data in it   
            byte[] encryptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Set the rsa pulic key   
                rsa.FromXmlString(publicKey);

                // Encrypt the data and store it in the encyptedData Array   
                encryptedData = rsa.Encrypt(dataToEncrypt, false);
            }
            // Save the encypted data array into a file   
            File.WriteAllBytes(fileName, encryptedData);

            Console.WriteLine("Data has been encrypted");
        }

        // Method to decrypt the data withing a specific file using a RSA algorithm private key   
        static string DecryptDataRSA(string privateKey, string fileName)
        {
    /*        RSACryptoServiceProvider publicX509key = Crypto.DecodeX509PublicKey(publicKeyStr);
            RSACryptoServiceProvider privateRSAkey = Crypto.DecodeRsaPrivateKey(privateKeyStr);*/
            // read the encrypted bytes from the file   
            byte[] dataToDecrypt = File.ReadAllBytes(fileName);

            // Create an array to store the decrypted data in it   
            byte[] decryptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Set the private key of the algorithm   
                rsa.FromXmlString(privateKey);
                decryptedData = rsa.Decrypt(dataToDecrypt, false);
            }

            // Get the string value from the decryptedData byte array   
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            return byteConverter.GetString(decryptedData);
        }

        public void GenKey()
        {
            // This example assumes the Chilkat API to have been previously unlocked.
            // See Global Unlock Sample for sample code.

            Chilkat.Rsa rsa = new Chilkat.Rsa();

            // Generate a 1024-bit key.  Chilkat RSA supports
            // key sizes ranging from 512 bits to 4096 bits.
            bool success = rsa.GenerateKey(1024);
            if (success != true)
            {
                Debug.WriteLine(rsa.LastErrorText);
                return;
            }

            // Keys are exported in XML format:
            string publicKeyXml = rsa.ExportPublicKey();
            Debug.WriteLine(publicKeyXml);

            string privateKeyXml = rsa.ExportPrivateKey();
            Debug.WriteLine(privateKeyXml);

            // Save the private key in PEM format:
            Chilkat.PrivateKey privKey = new Chilkat.PrivateKey();
            success = privKey.LoadXml(privateKeyXml);
            success = privKey.SaveRsaPemFile("privateKey.pem");

            // Save the public key in PEM format:
            Chilkat.PublicKey pubKey = new Chilkat.PublicKey();
            success = pubKey.LoadXml(publicKeyXml);
            success = pubKey.SaveOpenSslPemFile("publicKey.pem");
        }
    }
}
