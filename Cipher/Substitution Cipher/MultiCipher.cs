using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher.Substitution_Cipher
{
    /// <summary>
    /// 곱셈 암호
    /// </summary>
    public class MultiCipher
    {
        public static string Encrypt(string message, int key)
        {
            char[] a = message.ToCharArray();

            for (int i = 0; i < a.Length; i++) {
                if (!char.IsWhiteSpace(a[i])) {
                    a[i] = (char)('A' + ((a[i] - 'A') * key) % 26);

                }
            }

            return new string(a);
        }

        public static string Decrypt(string cipher, int key) {
            char[] a = cipher.ToCharArray();

            //곱셈 역원 계산
            int inverseKey = GetMultiplicativeInverse(key);

            for (int i = 0; i < a.Length; i++) {
                if (!char.IsWhiteSpace(a[i])) {
                    a[i] = (char)('A' + ((a[i] - 'A') * inverseKey) % 26);
                }
            }
                       
            return new string(a);
        }

        private static int GetMultiplicativeInverse(int key) {
            // 1~25 까지 순차적으로 대입
        
            for (int i = 1; i < 26; i++) {
                if ((key * i) % 26 == 1) {
                    return i;
                }    
            }
            
            throw new InvalidOperationException();
        }

        internal static void HowToTest()
        {
            string message = "ATTACK WEST CASTLE".ToUpper();
            var caesar = new CaesarCipher();
            string cipher = caesar.Encrypt(message);
            string plain = caesar.Decrypt(cipher);

            Console.WriteLine($"{message},{cipher},{plain}");
            Debug.Assert(message == plain);

        }
 
    }
}
