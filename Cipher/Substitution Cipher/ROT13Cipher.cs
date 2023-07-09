using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher.Substitution_Cipher
{
    public class ROT13Cipher
    {
        // ROT13 매핑테이블
        private static string ROT = "NOPQRSTUVWXYZABCDERGHIJKLM";

        public static string Encrypt(string message) {
            return Rotate(message);
        }

        public static string Decrypt(string cipher) {
            return Rotate(cipher);
        }

        private static string Rotate(string str)
        {
            char[] a = str.ToCharArray();

            for (int i = 0; i < a.Length; i++) {
                a[i] = (a[i] == ' ') ? ' ' : ROT[a[i] - 'A'];
            }

            return new string(a);
        }

        internal static void HowToTest() {
            string message = "ATTACK WEST CASTLE";
            string cipher = ROT13Cipher.Encrypt(message);
            string plain = ROT13Cipher.Decrypt(cipher);

            Console.WriteLine($"{message}, {cipher}, {plain}");
            Debug.Assert(message == plain);
        }
    }
}
