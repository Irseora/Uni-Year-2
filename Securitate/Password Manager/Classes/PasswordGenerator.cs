using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    internal class PasswordGenerator
    {
        #region Constants
        // Position of first & last exclude flag in config array
        const int posOfSymbols = 0;
        const int posOfExcludeSimilarChars = 4;
        const int posOfExcludeAmbiguousChars = 5;
        #endregion

        // ------------------------------------------------------------------------------

        #region Private Properties
        /// <summary>Required length of password</summary>
        private int requiredLength;

        /// <summary>
        /// List of allowed characters, divided into sections: <br/ >
        /// - symbols <br/ >
        /// - numbers <br/ >
        /// - lowercase letters <br/ >
        /// - uppercase letters <br/ >
        /// </summary>
        private List<string> allowedCharSets;

        private Random rnd = new Random();
        #endregion

        // ------------------------------------------------------------------------------

        #region Constructors
        /// <summary>
        /// Create a password generator based on provided config
        /// </summary>
        /// <param name="pwdLength">Length of passwords</param>
        /// <param name="config">Configuration flags</param>
        public PasswordGenerator(int pwdLength, bool[] config)
        {
            requiredLength = pwdLength;
            allowedCharSets = CreateAllowedCharSet(config);
        }
        #endregion

        // ------------------------------------------------------------------------------

        #region Private Methods
        /// <summary>
        /// Creates the list of allowed characters for password generation, based on config
        /// </summary>
        /// <param name="config">Configuration flags</param>
        /// <returns>List of allowed characters</returns>
        private List<string> CreateAllowedCharSet(bool[] config)
        {
            List<string> allowedCharSet = new List<string>();

            List<string> allCharSets = new List<string>()
            {
                "!@#$%^&*-_=+{}[]()/\\'\"`~,;:.<>?",
                "0123456789",
                "abcdefghijklmnopqrstuvwxyz",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            };

            // Add included characters
            for (int i = 0; i < posOfExcludeSimilarChars; i++)
                if (config[i])
                    allowedCharSet.Add(allCharSets[i]);

            // Remove similar characters from all allowed sets
            if (!config[posOfExcludeSimilarChars])
                for (int i = 0; i < allowedCharSet.Count; i++)
                    allowedCharSet[i] = Regex.Replace(allowedCharSet[i], "[ilI1Lo0O]", string.Empty);

            // Remove ambiguous characters from symbols (if included)
            if (!config[posOfExcludeAmbiguousChars] && config[posOfSymbols])
                allowedCharSet[posOfSymbols] = Regex.Replace(allowedCharSet[posOfSymbols], "[{}\\[\\]()/\\\'\"`~,;:.<>?]", string.Empty);

            return allowedCharSet;
        }
        #endregion

        // ------------------------------------------------------------------------------

        #region Public Methods
        /// <summary>
        /// Generates a password according to given config
        /// </summary>
        /// <returns>Generated password as a string</returns>
        public string GeneratePassword()
        {
            string password = "";

            while (password.Length < requiredLength)
            {
                // Pick a random character set
                int randomCharSetIdx = rnd.Next(0, allowedCharSets.Count);

                // Pick a random character from chosen set
                int randomCharIdx = rnd.Next(0, allowedCharSets[randomCharSetIdx].Length);

                password += allowedCharSets[randomCharSetIdx][randomCharIdx];
            }

            return password;
        }
        #endregion
    }
}
