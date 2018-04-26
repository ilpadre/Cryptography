using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicSchemes
{
    public class CaesarCipher
    {
        private string alphabet = $"abcdefghijklmnopqrstuvwxyz";
        private int shift = 3;
        public string Encrypt(string plainText)
        {
            var charArray = plainText.ToLower().ToCharArray();
            string cipherText = string.Empty;
            for (int i = 0; i <= charArray.Length - 1; i++)
            {
                var ch = charArray[i];
                var index = alphabet.IndexOf(ch);
                if (index >= 0)
                {
                    index = (index + shift) % alphabet.Length;
                    cipherText += alphabet[index];
                }
                else
                {
                    cipherText += ' ';
                }

            }
            
            return cipherText;
        }

        public string Decrypt(string cipherText)
        {
            var charArray = cipherText.ToLower().ToCharArray();
            string plainText = string.Empty;
            for (int i = 0; i <= charArray.Length - 1; i++)
            {
                var ch = charArray[i];
                var index = alphabet.IndexOf(ch);
                if (index >= 0)
                {
                    index = (index - shift) % alphabet.Length;
                    plainText += alphabet[index];
                }
                else
                {
                    plainText += ' ';
                }

            }
            return plainText;
        }
    }
}
