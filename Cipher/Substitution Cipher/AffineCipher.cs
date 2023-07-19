using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher.Substitution_Cipher
{
    public class AffineCipher
    {
        private int k1;
        private int k2;

        public AffineCipher(int k1, int k2) {
            this.k1 = k1;
            this.k2 = k2;
        }

        //Affine 암호화
        public string Encrypt(string message)
        {
            char[] a = message.ToCharArray();

            for (int i = 0; i < a.Length; i++) 
            {
                if (!char.IsWhiteSpace(a[i])) 
                {
                    a[i] = (char)('A' + ((a[i] - 'A') * k1 + k2) % 26);
                }
            }

            return new string(a);
        
        }

        //Affine 복호화
        public string Decrypt(string cipher)
        {
            char[] a = cipher.ToCharArray();
            
            //곱셈 역원을 계산
            int k1_inverse = Enumerable.Range(1, 25).Single(i =>(k1 * i) % 26 == 1);

            for (int i = 0; i < a.Length; i++) {
                if (!char.IsWhiteSpace(a[i])) {
                    int tmp = (a[i] - 'A' - k2 + 26);
                    a[i] = (char)('A' + (tmp * k1_inverse) % 26);
                }
            }

            return new string(a);
        }

        internal static void HowToTest()
        {
            var affine = new AffineCipher(7, 5);

            string message = "ATTACK WEST CASTLE".ToUpper();
            var caesar = new CaesarCipher();
            string cipher = affine.Encrypt(message);
            string plain = affine.Decrypt(cipher);

            Console.WriteLine($"{message},{cipher},{plain}");
            Debug.Assert(message == plain);

        }
    }
}
