using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    internal static class PasswordManager
    {
        #region Constants
        private const string savedPasswordsPath = @"E:\Repos\Securitate\Password Manager\test.bin";
        #endregion

        // ------------------------------------------------------------------------------

        #region Private Properties
        #endregion

        // ------------------------------------------------------------------------------

        #region Constructors
        //public PasswordManager()
        //{

        //}
        #endregion

        // ------------------------------------------------------------------------------

        #region Private Methods
        /// <summary>
        /// Encrypts given plain text with given key and random IV
        /// </summary>
        /// <param name="plainText">Plain text to encrypt</param>
        /// <param name="key">Key to use for encryption</param>
        /// <returns>Encrypted text and IV used</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static List<byte[]> Encrypt(string plainText, string key)
        {
            // Validate arguments
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");

            byte[] encryptedText, ivUsed;
            using (Aes aes = Aes.Create())
            {
                // Init
                aes.KeySize = 128;
                aes.Key = Encoding.ASCII.GetBytes(key);
                aes.GenerateIV();

                // Save IV
                ivUsed = aes.IV;

                // Create encryptor
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                // Create streams used for encryption
                using (MemoryStream msEncrypt =  new MemoryStream())
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            swEncrypt.Write(plainText);
                        encryptedText = msEncrypt.ToArray();
                    }
            }

            return new List<byte[]>() {  encryptedText, ivUsed };
        }

        /// <summary>
        /// Decrypts given encrypted text with given key and iv
        /// </summary>
        /// <param name="encryptedText">Encrypted text to decrypt</param>
        /// <param name="key">Key to use for decryption</param>
        /// <param name="iv">IV to use for decryption</param>
        /// <returns>Decrypted plain text</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static string Decrypt(string encryptedText, string key, string iv)
        {
            // Validate arguments
            if (encryptedText == null || encryptedText.Length <= 0)
                throw new ArgumentNullException("encryptedText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("iv");

            string plainText;
            using (Aes aes = Aes.Create())
            {
                // Init
                aes.KeySize = 128;
                aes.Key = Encoding.ASCII.GetBytes(key);
                aes.IV = Encoding.ASCII.GetBytes(iv);
                byte[] encryptedTextAsBytes = Encoding.ASCII.GetBytes(encryptedText);

                // Create decryptor
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                // Create streams used for decryption
                using (MemoryStream msDecrypt = new MemoryStream(encryptedTextAsBytes))
                    using (CryptoStream csDecrypt =  new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            plainText = srDecrypt.ReadToEnd();
            }

            return plainText;
        }
        #endregion

        // ------------------------------------------------------------------------------

        #region Public Methods
        public static void AddEntry(string service, string plainTextPassword, string key)
        {
            // Encrypt password
            List<byte[]> temp = Encrypt(plainTextPassword, key);
            byte[] encryptedPassword = temp[0];
            byte[] ivUsed = temp[1];

            /* Write to file
            // TODO: make less insane
            using (var sw = new StreamWriter(savedPasswordsPath, true))
                sw.Write(service + " " + encryptedPassword.Length + " ");
            using (var stream = new FileStream(savedPasswordsPath, FileMode.Append, FileAccess.Write))
                stream.Write(encryptedPassword, 0, encryptedPassword.Length);
            using (var sw = new StreamWriter(savedPasswordsPath, true))
                sw.Write(" " + ivUsed.Length + " ");
            using (var stream = new FileStream(savedPasswordsPath, FileMode.Append, FileAccess.Write))
                stream.Write(ivUsed, 0, ivUsed.Length);
            using (var sw = new StreamWriter(savedPasswordsPath, true))
            {
                sw.WriteLine();
                sw.WriteLine();
            }
            */

            // Write to file
            using (BinaryWriter bw = new BinaryWriter(File.Open(savedPasswordsPath, FileMode.Append)))
            {
                byte[] serviceAsBytes = Encoding.ASCII.GetBytes(service);
                bw.Write(serviceAsBytes.Length);
                bw.Write(serviceAsBytes);

                bw.Write(encryptedPassword.Length);
                bw.Write(encryptedPassword);

                bw.Write(ivUsed.Length);
                bw.Write(ivUsed);
            }

            /* Read from file
            using (FileStream fs = new FileStream(savedPasswordsPath, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                int temp1 = br.ReadInt32();
                byte[] temp2 = new byte[temp1];
                br.Read(temp2, 0, temp1);
                string temp3 = Encoding.ASCII.GetString(temp2);
            }   
            */
        }

        public static void RemoveEntry(string service)
        {
            // Find service

            // Remove line
        }

        public static string GetPassword(string service) // Needs master password
        {
            // Find service

            // Decrypt password
                // Ask for master password

            // Return password

            return null;
        }
        #endregion
    }
}
