using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Cipher.Substitution_Cipher
{
    public class RandomCipher
    {
        // 랜덤 매핑 테이블
        private readonly char[] table;

        public RandomCipher(string keyTable = null) {
            // 외부에서 키를 제공할 경우 그 키를 사용
            if (keyTable != null) {
                Debug.Assert(keyTable.Length == 26);
                table = keyTable.ToCharArray();
            }
            else { //키가 제공되지 않을 경우 키 생성
                table = CreateRandomTable();                         
            }
        }

        // A ~ Z 중 하나씩 골라 랜덤 테이블에 저장
        private char[] CreateRandomTable()
        {
            List<char> randomTable = new List<char>();

            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
            Random random = new Random();

            while (alphabet.Count > 0) {
                int rand = random.Next(0, alphabet.Count - 1);
                randomTable.Add(alphabet[rand]);
                alphabet.RemoveAt(rand);
            }

            return randomTable.ToArray();

        }

        public string Encrypt(string message)
        {
            char[] a = message.ToCharArray();

            for (int i = 0; i < a.Length; i++) {
                a[i] = (a[i] == ' ') ? ' ' : table[a[i] - 'A'];
            }

            return new string(a);
        }

        public string Decrypt(string cipher)
        {
            char[] a = cipher.ToCharArray();

            for (int i = 0; i < a.Length; i++) {
                if (a[i] != ' ') {
                    for (int t = 0; t < table.Length; t++) {
                        if (a[i] == table[t]) {
                            a[i] = (char)('A' + t);
                            break;

                        } //end if
                    } //end for
                } //and if
            } //and for

            return new string(a);
        }
    }
}
