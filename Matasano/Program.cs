using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace Matasano
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello Matasano");

            //Set1.Challenge1();
            WriteLine("Hex->Bytes f = {0}; ff = {1}", Cryptopal.HexToBytes("f")?.Length, Cryptopal.HexToBytes("ff")?.Length);
            var str = from ch in "abc"
                      select ch.ToString() + "foo";
            WriteLine(String.Join(" ", str));
            ReadKey();
        }


    }

    class Set1
    {
        public static void Challenge1()
        {
            var b64_input = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
            var b64_output = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";
            try
            {
                var b64_bytes = Cryptopal.HexToBytes(b64_input);
                WriteLine("{0} = base64({1})\n{2} = expected", Cryptopal.Base64Encode(b64_bytes), b64_input, b64_output);
            } catch (ArgumentNullException e)
            {
                WriteLine("Failed! {0}", e);
            }
            

        }
    }
}
