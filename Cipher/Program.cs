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

            Console.WriteLine("Hello world");
        }

        public Dictionary<string, string>  makeCodebook()
        {
            var decbook = new Dictionary<string, string>() {
                { "5", "a"},
                { "2", "b"},
                { "#", "d"},
                { "8", "e"},
                { "1", "f"},
                { "3", "g"},
                { "4", "h"},
                { "6", "i"},
                { "0", "l"},
                { "9", "m"},
                { "*", "n"},
                { "%", "o"},
                { "=", "p"},
                { "(", "r"},
                { ")", "s"},
                { ";", "t"},
                { "?", "u"},
                { "@", "v"},
                { ":", "fy"},
                { "7", " "}
            };

            var encbook = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> item in decbook) {
                encbook.Add(item.Value, item.Key);
            }

            return encbook;
        }
    }
}
