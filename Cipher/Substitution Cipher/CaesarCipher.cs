using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher.Substitution_Cipher
{
    /// <summary>
    /// 시저 암호
    /// </summary>
    public class CaesarCipher
    {
        private const int DEFAULT_KEY = 3;
        private readonly int key;

        public CaesarCipher(int key = DEFAULT_KEY)
        {
            this.key = key;
        }

        public string Encrypt(string message)
        {
            char[] a = message.ToCharArray();

            for (int i = 0; i < a.Length; i++) {
                //문자가 공백인지여부를 판단
                if (char.IsWhiteSpace(a[i])) continue;
                // 영문자를 Key 만큼 이동한 값이 알파벳의 마지막 문자보다 클 경우,
                // 알파벳의 처음으로 돌아오도록 하기 위해
                a[i] = (char)('A' + (a[i] - 'A' + key) % 26);
            }

            return new string(a);
        }

        public string Decrypt(string cipher) {
            char[] a = cipher.ToCharArray();

            for (int i = 0; i < a.Length; i++) {
                if (char.IsWhiteSpace(a[i])) continue;

                int ch = (a[i] - 'A' + 26 - key) % 26;
                a[i] = (char)('A' + ch);
            }

            return new string(a);
        }

        //테스트
        internal static void HowToTest() {
            string message = "ATTACK WEST CASTLE".ToUpper();
            var caesar = new CaesarCipher();
            string cipher = caesar.Encrypt(message);
            string plain = caesar.Decrypt(cipher);

            Console.WriteLine($"{message},{cipher},{plain}");
            Debug.Assert(cipher == "DWWDFN ZHVW FDVWOH");
            Debug.Assert(message == plain);
           
        }


        
    }
}
