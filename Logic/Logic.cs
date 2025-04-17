using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;

namespace TransactionDataApiSettlement.Logic
{
    public class Logic
    {
        public static String MaskedNumber(String source)
        {
            StringBuilder sb = new StringBuilder(source);

            const int skipLeft = 6;
            const int skipRight = 4;

            int left = -1;

            for (int i = 0, c = 0; i < sb.Length; ++i)
            {
                if (Char.IsDigit(sb[i]))
                {
                    c += 1;

                    if (c > skipLeft)
                    {
                        left = i;

                        break;
                    }
                }
            }

            for (int i = sb.Length - 1, c = 0; i >= left; --i)
                if (Char.IsDigit(sb[i]))
                {
                    c += 1;

                    if (c > skipRight)
                        sb[i] = 'X';
                }

            return sb.ToString();
        }

        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static string AESEncrypyt(string strToEncrypt, byte[] bytes)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = bytes.Take(16).ToArray();
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                byte[] encrypted;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] inputBuffer = Encoding.UTF8.GetBytes(strToEncrypt);
                        cs.Write(inputBuffer, 0, inputBuffer.Length);
                    }

                    encrypted = ms.ToArray();
                }

                return Convert.ToBase64String(encrypted);
            }
        }


        public static string SignData(string message, RSACryptoServiceProvider provider)
        {
            //// The array to store the signed message in bytes
            byte[] signedBytes;
            using (var rsa = provider)
            {
                //// Write the message to a byte array using UTF8 as the encoding.
                var encoder = new UTF8Encoding();
                byte[] originalData = encoder.GetBytes(message);

                try
                {
                    /*//// Import the private key used for signing the message
                    rsa.ImportParameters(privateKey);*/

                    //// Sign the data, using SHA512 as the hashing algorithm 
                    //signedBytes = rsa.SignData(originalData, CryptoConfig.MapNameToOID("SHA512"));
                    signedBytes = rsa.SignData(originalData, HashAlgorithmName.SHA256, System.Security.Cryptography.RSASignaturePadding.Pkcs1);
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                finally
                {
                    //// Set the keycontainer to be cleared when rsa is garbage collected.
                    rsa.PersistKeyInCsp = false;
                }
            }
            //// Convert the a base64 string before returning
            return Convert.ToBase64String(signedBytes);
        }

        /* public static RSACryptoServiceProvider GetRsaParameters(string rsaPrivateKey)
         {
             rsaPrivateKey = rsaPrivateKey.Replace("\r", "").Replace("\n", "");//.Replace(" ", "");
             var byteArray = Encoding.ASCII.GetBytes(rsaPrivateKey);
             using var ms = new MemoryStream(byteArray);
             using var sr = new StreamReader(ms);            // Read the PKCS1 PEM private key
             var pemReader = new PemReader(sr);
             var keyPair = (AsymmetricCipherKeyPair)pemReader.ReadObject();
             var privateKeyParams = (RsaPrivateCrtKeyParameters)keyPair.Private;            // Convert the BouncyCastle private key parameters to .NET RSAParameters
             var rsaParams = DotNetUtilities.ToRSAParameters(privateKeyParams as RsaPrivateCrtKeyParameters);            // Initialize the RSACryptoServiceProvider with the private key
             var csp = new RSACryptoServiceProvider();
             csp.ImportParameters(rsaParams);
             return csp;
         }*/
        public static RSACryptoServiceProvider GetRsaParameters(string rsaPrivateKey)
        {
            var byteArray = Encoding.ASCII.GetBytes(rsaPrivateKey);
            using (var ms = new MemoryStream(byteArray))
            {
                using (var sr = new StreamReader(ms))
                {
                    var pemReader = new Org.BouncyCastle.Utilities.IO.Pem.PemReader(sr);
                    var pem = pemReader.ReadPemObject();
                    var privateKey = PrivateKeyFactory.CreateKey(pem.Content);
                    RSACryptoServiceProvider csp = new RSACryptoServiceProvider();// cspParams);
                    csp.ImportParameters(DotNetUtilities.ToRSAParameters(privateKey as RsaPrivateCrtKeyParameters));
                    return csp;
                }
            }

        }

        public static byte[] SignNew(string data, string path, string password)
        {
            X509Certificate2 privateCert = new X509Certificate2(path, password, X509KeyStorageFlags.Exportable);

            // This instance can not sign and verify with SHA256:
            // RSACryptoServiceProvider privateKey = (RSACryptoServiceProvider)privateCert.PrivateKey;

            RSA rssa = (RSA)privateCert.PrivateKey;
            (privateCert.PrivateKey as RSACng).Key.SetProperty(
                new CngProperty(
                    "Export Policy",
                    BitConverter.GetBytes((int)CngExportPolicies.AllowPlaintextExport),
                    CngPropertyOptions.Persist));

            RSAParameters RSAParameters = rssa.ExportParameters(true);
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(RSAParameters);
                    byte[] dataBytes = System.Text.Encoding.UTF8.GetBytes(data);
                    return rsa.SignData(dataBytes, /*new SHA1CryptoServiceProvider()*/HashAlgorithmName.SHA256);
                }
            }
            catch (CryptographicException exception)
            {
                Console.WriteLine("Sign Function: " + exception.Message);
                //throw new BusinessException(exception);

                return null;
            }
        }

        public static bool VerifySignature(string encrypted, string sig, string path)
        {
            string text = string.Empty;

            X509Certificate2 cert = new X509Certificate2(@"D:\Downloads\_.fcmb.com24(1)\27fec7b6325d9e0f.crt");
            bool v = false;


            using (RSA rsa = cert.GetRSAPublicKey())
            {
                v = rsa.VerifyData(Encoding.ASCII.GetBytes(encrypted), Convert.FromBase64String(sig), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
            return v;
        }


        public static string AESDecrypt(string strToDecrypt, byte[] secret)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = secret.Take(16).ToArray();
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                byte[] encryptedBytes = Convert.FromBase64String(strToDecrypt);

                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }



        public static string AESDecrypyt(string strToEncrypt, byte[] bytes)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = bytes.Take(16).ToArray();
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                byte[] decryptedBytes;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] inputBuffer = Encoding.UTF8.GetBytes(strToEncrypt);
                        cs.Write(inputBuffer, 0, inputBuffer.Length);
                    }

                    decryptedBytes = ms.ToArray();
                }

                return System.Text.Encoding.ASCII.GetString(decryptedBytes);
            }
        }


        public static List<String> GetFiles(string path, SftpClient client)
        {
            using (client)
            {
                //client.Connect();
                return client
                    .ListDirectory(path)
                    .Where(f => !f.IsDirectory)
                    .Select(f => f.Name)
                    .ToList();
            }
        }
        public static void byEmail(notifyparams param, string subject, string recipients, string body)
        {
            MailMessage reportEmail = new MailMessage();
            SmtpClient smtp = new SmtpClient(param.smtpclient, int.Parse(param.smtpport));

            reportEmail.IsBodyHtml = true;
            reportEmail.From = new MailAddress(param.mailFrom);

            smtp.Credentials = new NetworkCredential(param.netUsr, param.netPas);

            foreach (string recipient in recipients.Split(';'))
            {
                reportEmail.To.Add(recipient);
            }

            reportEmail.Subject = subject;

            reportEmail.Body = body;
            smtp.SendAsync(reportEmail, "");
        }
        public static SftpClient connectSftp(string name, bool n)
        {

            //var client = new SftpClient("172.16.112.113", 22, "ngupload", "P@$$word12");
            var client = new SftpClient("172.16.111.17", 22, "kadiapi", "WjEG6y3cHt3SJTaz");
            client.Connect();

            return client;
        }

        public static void DownloadAll()
        {
            try
            {
                string host = "172.16.112.71";
                string username = "oracle";
                string password = "Vision2024!!";

                string remoteDirectory = "/data/kadifiles/postcardfiles/sombank/";
                string localDirectory = @"C:\inetpub\wwwroot\PUB004\sftpfiles\";
                //string localDirectory = @"D:\Keys\sftpfiles\";
                using (var sftp = new SftpClient(host, username, password))
                {
                    sftp.Connect();
                    var files = sftp.ListDirectory(remoteDirectory);

                    foreach (var file in files)
                    {
                        string remoteFileName = file.Name;
                        if ((!file.Name.StartsWith(".")) && (file.LastWriteTime.Date == DateTime.Today))
                        {
                            using (Stream file1 = File.Create(localDirectory + remoteFileName))
                            {
                                sftp.DownloadFile(remoteDirectory + remoteFileName, file1);
                                sftp.DeleteFile(remoteDirectory + remoteFileName);
                            }

                            try
                            {
                                Console.WriteLine("File uploaded started at {0}.", DateTime.Now);
                                ImpersonateAndCopyFile(".\\", "ndungus", "Sam@3193#2422", localDirectory + remoteFileName, "\\\\172.16.112.7\\data\\SomBank\\EmvScriptsLoad_Standard\\" + remoteFileName);
                                Console.WriteLine("File uploaded completed successfully at {0}.", DateTime.Now);
                            }
                            catch (Exception ex)
                            {
                                Logic.WriteLog("Errorlog" + ex.ToString());
                                Console.WriteLine($"An error occurred: {ex.Message}");
                            }
                        }


                    }

                }
            }
            catch (Exception ex) {
                Logic.WriteLog("Errorlog" + ex.ToString());
            } 
        }

        static void ImpersonateAndCopyFile(string domain, string username, string password, string sourceFilePath,
string destinationFilePath)
        {
            var userToken = IntPtr.Zero;

            try
            {
                var isSuccess = LogonUser(username, "paynet.co.ke", password, 2, 0, ref userToken);
                if (!isSuccess)
                {
                    throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
                }

                using WindowsIdentity identity = new WindowsIdentity(userToken);
                WindowsIdentity.RunImpersonated(identity.AccessToken, () =>
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                });
            }
            finally
            {
                if (userToken != IntPtr.Zero)
                {
                    CloseHandle(userToken);
                }
            }
        }

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool LogonUser(
           string lpszUsername,
         string lpszDomain,
           string lpszPassword,
            int dwLogonType,
            int dwLogonProvider,
            ref IntPtr phToken);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern bool CloseHandle(IntPtr handle);


        public static bool copySSHFiles(SftpClient client, string sourcefile, string destdir, bool delete)
        {
            bool resp = false;
            try
            {


                using (var s = File.OpenRead(sourcefile))
                {
                    client.UploadFile(s, destdir + "/" + Path.GetFileName(sourcefile));
                }


                resp = true;
                if (delete)
                    File.Delete(sourcefile);
            }
            catch (Exception ex)
            {
                client.CreateDirectory(destdir);

            }
            return resp;
        }
        public static String maskCardNumber(String cardNumber, String mask)
        {

            // format the number
            int index = 0;
            StringBuilder maskedNumber = new StringBuilder();
            for (int i = 0; i < mask.Length; i++)
            {
                char c = mask[i];
                if (c == '#')
                {
                    maskedNumber.Append(cardNumber[index]);
                    index++;
                }
                else if (c == '*')
                {
                    maskedNumber.Append(c);
                    index++;
                }
                else
                {
                    maskedNumber.Append(c);
                }
            }

            // return the masked number
            return maskedNumber.ToString();
        }
        public static double ToJulianDate(DateTime date)
        {
            return date.ToOADate() + 2415018.5;
        }

        public static void WriteLog(string strLog)
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;
            string _rptPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\logs\\";
            //string logFilePath = @"C:\Logs\";
            _rptPath = _rptPath + "Log-tran_" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
            logFileInfo = new FileInfo(_rptPath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(_rptPath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            log.WriteLine("Transaction  API");
            log.WriteLine(strLog);

            log.Close();
        }

        public static string generateKey()
        {
            string keyBase64Key = string.Empty;
            Console.WriteLine("Creating Aes Encryption 256 bit key");
            using (Aes aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.KeySize = 256;
                aesAlgorithm.Mode = CipherMode.ECB;
                aesAlgorithm.Padding = PaddingMode.PKCS7;
                aesAlgorithm.GenerateKey();
                keyBase64Key = Convert.ToBase64String(aesAlgorithm.Key);
                Console.WriteLine($"Aes Key Size : {aesAlgorithm.KeySize}");
                Console.WriteLine($"keyBase64Key Size : {keyBase64Key.Length}");
                Console.WriteLine("Here is the Aes key in Base64:");
                Console.WriteLine(keyBase64Key);
            }
            return keyBase64Key;
        }

        /*    public static void DownloadAll()
            {
                string host = @"172.16.111.17";
                string username = "isw_tx_reports";
                string password = "Fxl~8tm&jxNrbm?";

                string remoteDirectory = "/exported/reports/gblk/";
                string localDirectory = @"C:\Program Files (x86)\RDS Programs\Autoops\service\workdir";

                using (var sftp = new SftpClient(host, username, password))
                {
                    sftp.Connect();
                    var files = sftp.ListDirectory(remoteDirectory);

                    foreach (var file in files)
                    {
                        string remoteFileName = file.Name;
                        using (Stream file1 = File.Create(localDirectory + remoteFileName))
                            {
                                sftp.DownloadFile(remoteDirectory + remoteFileName, file1);
                            }
                    }

                }
            }*/

        public static string getFileUploadEmail(List<string> files, string template,string inst)
        {
            string body = template;
            body = body.Replace("?tm?", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
            body = body.Replace("?inst?", inst);
            body = body.Replace("?nw?", files.Count().ToString());
            body = body.Replace("?up?", String.Join(", ", files.ToArray()));
            return body;
        
        }

    }

 


    public class notifyparams
    {
        public string smtpclient;
        public string smtpport;
        public string mailFrom;
        public string netPas;
        public string netUsr;
        public string notymail;
        public string body;
        public string subject;

    }

}
