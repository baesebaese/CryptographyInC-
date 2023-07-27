using Cipher.Substitution_Cipher;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher.Poly_Substitution_Cipher
{
    public class VigenereCipher
    {
        public static string Encrypt(string message, string key) {
            char[] a = message.ToCharArray();
            char[] k = key.ToCharArray();
            int kIndex = -1;

            for (int i = 0; i < a.Length; i++) {
                if (char.IsWhiteSpace(a[i])) continue;

                kIndex = (kIndex >= k.Length - 1) ? 0 : kIndex + 1;
                int iKey = k[kIndex] - 'A';

                a[i] = (char)('A' + ((a[i] - 'A') + iKey) % 26);
                
            }
        
            return new string(a);
        }


        public static string Decrypt(string cipher, string key)
        {
            char[] a = cipher.ToCharArray();
            char[] k = key.ToCharArray();
            int kIndex = -1;

            for (int i = 0; i < a.Length; i++) {
                if (char.IsWhiteSpace(a[i])) continue;

                kIndex = (kIndex >= k.Length - 1) ? 0 : kIndex + 1;
                int iKey = k[kIndex] - 'A';

                a[i] = (char)('A' + (a[i] - 'A' - iKey + 26) % 26);

            }

            return new string(a);
        }
        internal static void HowToTest()
        {
            string message = "ATTACK WEST CASTLE".ToUpper();
            string key = "JULIA".ToUpper();
            string cipher = VigenereCipher.Encrypt(message, key);
            string plain = VigenereCipher.Decrypt(cipher, key);

            Console.WriteLine($"{message},{cipher},{plain}");
            Debug.Assert(message == plain);

        }
    }


}
