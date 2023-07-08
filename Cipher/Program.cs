using Cipher.Substitution_Cipher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 시저 암호
            CaesarCipher caesarCipher = new CaesarCipher();
            var encryptStr = caesarCipher.Encrypt("HELLO");
            var decryptStr = caesarCipher.Decrypt(encryptStr);

            Console.WriteLine("암호화:" + encryptStr);
            Console.WriteLine("복호화:" + decryptStr);
        }

    }
}
