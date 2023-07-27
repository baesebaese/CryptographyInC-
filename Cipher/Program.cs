using Cipher.Poly_Substitution_Cipher;
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
            var decryptRot13Str = ROT13Cipher.Decrypt(encryptRot13Str);

            RandomCipher randomCipher = new RandomCipher();
            Console.WriteLine("ROT13 암호화:" + encryptRot13Str);
            Console.WriteLine("ROT13 복호화:" + decryptRot13Str);

            var encryptRandomStr = randomCipher.Encrypt("HELLO");
            var decryptRandomStr = randomCipher.Decrypt(encryptRandomStr);

            Console.WriteLine("Random 암호화:" + encryptRandomStr);
            Console.WriteLine("Random 복호화:" + decryptRandomStr);

            var encryptMulti = MultiCipher.Encrypt("HELLO", 3);
            var decryptMulti = MultiCipher.Decrypt(encryptMulti, 3);

            Console.WriteLine("곱셈 암호화:" + encryptMulti);
            Console.WriteLine("곱셈 복호화:" + decryptMulti);

            var affine = new AffineCipher(7, 5);
            var encryptAffine = affine.Encrypt("HELLO");
            var decryptAffine = affine.Decrypt(encryptAffine);

            Console.WriteLine("아핀 암호화:" + encryptAffine);
            Console.WriteLine("아핀 복호화:" + decryptAffine);

            var encryptvigenere = VigenereCipher.Encrypt("HELLO", "BOB");
            var decryptVigenere = VigenereCipher.Decrypt(encryptvigenere, "BOB");

            Console.WriteLine("비제네르 암호화:" + encryptvigenere);
            Console.WriteLine("비제네르 복호화:" + decryptVigenere);

        }

    }
}
