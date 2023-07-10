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

            Console.WriteLine("Caesar 암호화:" + encryptStr);
            Console.WriteLine("Caesar 복호화:" + decryptStr);

            var encryptRot13Str = ROT13Cipher.Encrypt("HELLO");
            var decryptRot13Str = ROT13Cipher.Decrypt(encryptStr);

            RandomCipher randomCipher = new RandomCipher();
            Console.WriteLine("ROT13 암호화:" + encryptRot13Str);
            Console.WriteLine("ROT13 복호화:" + decryptRot13Str);

            var encryptRandomStr = randomCipher.Encrypt("HELLO");
            var decryptRandomStr = randomCipher.Decrypt(encryptStr);

            Console.WriteLine("Random 암호화:" + encryptRandomStr);
            Console.WriteLine("Random 복호화:" + decryptRandomStr);
        }

    }
}
