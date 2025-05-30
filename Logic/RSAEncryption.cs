﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;

using System.Security.Cryptography;
using System.Web;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Engines;
using System.Text;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Crypto.Encodings;

namespace TransactionDataApiSettlement.Logic
{
    public class RSAEncryption
    {
        static string publicKey = @"-----BEGIN PUBLIC KEY-----
        MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC7pbDRvuqRL0EsKjYGqPZWu4VF
        KI1iilisb3+yW5guIP4I+T8qhP8dcUugiwa2fDwGgl3Y+PHASGdCfvYOfMefWlNU
        oGeLv4Tx6nqvq2OcVzRhYjUfIpRE7z81xhmKtvxxLTNzTAoHN6rWqarKYMFydR/s
        D+oJs7LnnJoWieh1QQIDAQAB
        -----END PUBLIC KEY-----
        ";

        static string privateKey = @"-----BEGIN RSA PRIVATE KEY-----
        MIICXAIBAAKBgQC7pbDRvuqRL0EsKjYGqPZWu4VFKI1iilisb3+yW5guIP4I+T8q
        hP8dcUugiwa2fDwGgl3Y+PHASGdCfvYOfMefWlNUoGeLv4Tx6nqvq2OcVzRhYjUf
        IpRE7z81xhmKtvxxLTNzTAoHN6rWqarKYMFydR/sD+oJs7LnnJoWieh1QQIDAQAB
        AoGAPeQ4nfXKiHh9loOVrjysg472NglaGNZoyPc9tyZe21gmce9D1lJnkt57g0hX
        vnjbk4oMSjRSCInZBSW7IqwlauiYwJra5O7MbLFaCTWDDnwFB+Zcz9E2PbPdFQFl
        jyYfh0gm9zvo79oyqESXtfYaMfx45zPbJGOkhiPcjZDsZcECQQDyy2qz6L6JALIY
        L1CtY6NTSm33rXv6Y+RzTBZovkK9OvMODvklsOhbcNQx0o7vQ5600dbHORwteCcm
        cHMgFDGnAkEAxdpsD2omWPzRYCRmk72aqRtccp9AE9eE75mUG6sMt3NDqwGeTuWV
        EH70XC3yIwqFmkc3zzNjZqsxTEDtuRtu1wJBAJoAHpko2poJv+0JLfIczf7JqgC8
        oHPMop3jOB+N9sUSPBLBupSGpotBgMZtWM44pNTqeIH7Hn1UxfhiwRMq2+cCQDwZ
        K8fG450WNncwt2PbLRZ+9CbxDqK4TW4GRYHeBD/ZKE3ScQbgH9Zh6dHyNuHD+W8y
        gNZUcrYl/BSAiHU4ywMCQDok1QgvVmc8jma9qK2dxmd4IR8varRPti4VQAMumdaE
        4s1Ofdw+8Bl2FATkdQZDLUQbWat4E5l8uGLfYZAHSow=
        -----END RSA PRIVATE KEY-----";

   /*     static void Main()
        {
            try
            {
                RSACryptoServiceProvider RSApublicKey = ImportPublicKey(publicKey);

                RSACryptoServiceProvider RSAprivateKey = ImportPrivateKey(privateKey);

                var plainTextData = "test simple";

                System.Diagnostics.Debug.WriteLine("plainTextData : " + plainTextData);

                //for encryption, always handle bytes...
                var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);

                //apply pkcs#1.5 padding and encrypt our data 
                var bytesCypherText = RSApublicKey.Encrypt(bytesPlainTextData, false);

                //we might want a string representation of our cypher text... base64 will do
                var cypherText = Convert.ToBase64String(bytesCypherText);

                System.Diagnostics.Debug.WriteLine("cypherText : " + cypherText);
                *//*
                 * some transmission / storage / retrieval
                 * 
                 * and we want to decrypt our cypherText
                 *//*

                //first, get our bytes back from the base64 string ...
                bytesCypherText = Convert.FromBase64String(cypherText);

                //we want to decrypt, therefore we need a csp and load our private key


                //decrypt and strip pkcs#1.5 padding
                bytesPlainTextData = RSAprivateKey.Decrypt(bytesCypherText, false);

                //get our original plainText back...
                plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);

                System.Diagnostics.Debug.WriteLine("DecryptData : " + plainTextData);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("err : " + e.StackTrace);
            }

        }*/
        public static string getclearMessage(string message) 
        {

            RSACryptoServiceProvider RSAprivateKey = ImportPrivateKey(privateKey);
            byte[] bytesCypherText = Convert.FromBase64String(message);

            //we want to decrypt, therefore we need a csp and load our private key


            //decrypt and strip pkcs#1.5 padding
            byte []bytesPlainTextData = RSAprivateKey.Decrypt(bytesCypherText, RSAEncryptionPadding.Pkcs1);
            return System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
        }
        public static string encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            /*       PemReader pr = new PemReader(
                       (StreamReader)File.OpenText("./pem_public.pem")            );*/
            PemReader pr = new PemReader(new StringReader(publicKey));

            RsaKeyParameters keys = (RsaKeyParameters)pr.ReadObject();

            // Pure mathematical RSA implementation
           // RsaEngine eng = new RsaEngine();

            // PKCS1 v1.5 paddings
             Pkcs1Encoding eng = new Pkcs1Encoding(new RsaEngine());

            // PKCS1 OAEP paddings
            //OaepEncoding eng = new OaepEncoding(new RsaEngine());
            eng.Init(true, keys);

            int length = plainTextBytes.Length;
            int blockSize = eng.GetInputBlockSize();
            List<byte> cipherTextBytes = new List<byte>();
            for (int chunkPosition = 0;
                chunkPosition < length;
                chunkPosition += blockSize)
            {
                int chunkSize = Math.Min(blockSize, length - chunkPosition);
                cipherTextBytes.AddRange(eng.ProcessBlock(
                    plainTextBytes, chunkPosition, chunkSize
                ));
            }
            return Convert.ToBase64String(cipherTextBytes.ToArray());
        }

       public static string decrypt(string cipherText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PemReader pr = new PemReader(new StringReader(privateKey));
            AsymmetricCipherKeyPair keys = (AsymmetricCipherKeyPair)pr.ReadObject();

            // Pure mathematical RSA implementation
            //RsaEngine eng = new RsaEngine();

            // PKCS1 v1.5 paddings
             Pkcs1Encoding eng = new Pkcs1Encoding(new RsaEngine());

            // PKCS1 OAEP paddings
           // OaepEncoding eng = new OaepEncoding(new RsaEngine());
            eng.Init(false, keys.Private);

            int length = cipherTextBytes.Length;
            int blockSize = eng.GetInputBlockSize();
            List<byte> plainTextBytes = new List<byte>();
            for (int chunkPosition = 0;
                chunkPosition < length;
                chunkPosition += blockSize)
            {
                int chunkSize = Math.Min(blockSize, length - chunkPosition);
                plainTextBytes.AddRange(eng.ProcessBlock(
                    cipherTextBytes, chunkPosition, chunkSize
                ));
            }
            return Encoding.UTF8.GetString(plainTextBytes.ToArray());
        }

        public static RSACryptoServiceProvider ImportPrivateKey(string pem)
        {
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricCipherKeyPair KeyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)KeyPair.Private);

            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();// cspParams);
            csp.ImportParameters(rsaParams);
            return csp;
        }

        /// <summary>
        /// Import OpenSSH PEM public key string into MS RSACryptoServiceProvider
        /// </summary>
        /// <param name="pem"></param>
        /// <returns></returns>
        public static RSACryptoServiceProvider ImportPublicKey(string pem)
        {
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricKeyParameter publicKey = (AsymmetricKeyParameter)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaKeyParameters)publicKey);

            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();// cspParams);
            csp.ImportParameters(rsaParams);
            return csp;
        }


    }
}

