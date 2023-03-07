using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CriptograficiaPontaAPonta
{
    public class ChaveFixa
    {
        public static string CriaChaveFica(string CriaChaveFica)
        {
            byte[] salt = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 };
            int iterations = 10000;
            int keySize = 256;

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(CriaChaveFica, salt, iterations);
            byte[] key = pbkdf2.GetBytes(keySize / 8);
            string base64Key = Convert.ToBase64String(key);
            return base64Key;
        }
    }
}
