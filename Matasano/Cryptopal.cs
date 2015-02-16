using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matasano
{
    class Cryptopal
    {
        /*
        Convert hex to base64
        Fixed XOR
        Single-byte XOR cipher
        Detect single-character XOR
        Implement repeating-key XOR
        Break repeating-key XOR
        AES in ECB mode
        Detect AES in ECB mode
        */
        internal static string Base64Encode(string b64_input) 
        {
            byte[] bytes = Encoding.UTF8.GetBytes(b64_input);
            return Base64Encode(bytes);
        }

        internal static string Base64Encode(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }
            return Convert.ToBase64String(bytes);
        }
        internal static string Base64Decode(string b64_input)
        {
            byte[] bytes = Convert.FromBase64String(b64_input);
            return Base64Decode(bytes);
        }

        internal static string Base64Decode(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);

        }

        internal static byte[] HexToBytes(string hex)
        {
            return (
                    from character in hex
                    select Convert.ToByte(character.ToString(), 16)
                   ) as byte[];
        }
    }
}
