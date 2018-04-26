using System;

namespace BasicSchemes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CaesarCipher cc = new CaesarCipher();
            var plainText = "How now brown cow";
            var cipherText = cc.Encrypt(plainText);
            var newPlainText = cc.Decrypt(cipherText);

            Console.WriteLine($"Message text = {plainText}");
            Console.WriteLine($"Encrypted text = {cipherText}");
            Console.WriteLine($"Decrypted text = {newPlainText}");

            Console.ReadLine();
        }
    }
}
