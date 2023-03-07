using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CriptograficiaPontaAPonta
{
    public static class GetAndSetterEncodeCode
    {
        private static readonly int KeySize = 256; // tamanho da chave em bits
        private static readonly int BlockSize = 128; // tamanho do bloco em bits

        public static string EncryptString(string plainText, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] iv = new byte[BlockSize / 8]; // vetor de inicialização (IV) deve ter o mesmo tamanho do bloco

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = KeySize;
                aesAlg.BlockSize = BlockSize;
                aesAlg.Padding = PaddingMode.PKCS7;

                // ajusta o tamanho da chave, se necessário
                if (keyBytes.Length != aesAlg.KeySize / 8)
                {
                    keyBytes = DeriveKey(keyBytes, aesAlg.KeySize / 8);
                }

                aesAlg.Key = keyBytes;
                aesAlg.IV = iv;

                // cria um objeto MemoryStream para gravar os dados criptografados
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // cria um objeto de criptografia para criptografar os dados
                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                    {
                        // cria um objeto CryptoStream para escrever os dados criptografados no MemoryStream
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            // escreve os dados criptografados no MemoryStream
                            byte[] data = Encoding.UTF8.GetBytes(plainText);
                            csEncrypt.Write(data, 0, data.Length);
                        }
                    }

                    // retorna os dados criptografados como uma string Base64
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string DecryptString(string cipherText, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] iv = new byte[BlockSize / 8]; // vetor de inicialização (IV) deve ter o mesmo tamanho do bloco

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = KeySize;
                aesAlg.BlockSize = BlockSize;
                aesAlg.Padding = PaddingMode.PKCS7;

                // ajusta o tamanho da chave, se necessário
                if (keyBytes.Length != aesAlg.KeySize / 8)
                {
                    keyBytes = DeriveKey(keyBytes, aesAlg.KeySize / 8);
                }

                aesAlg.Key = keyBytes;
                aesAlg.IV = iv;

                // cria um objeto MemoryStream para ler os dados criptografados
                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    // cria um objeto de criptografia para descriptografar os dados
                    using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                    {
                        // cria um objeto CryptoStream para ler os dados criptografados do MemoryStream
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            // lê os dados descriptografados do CryptoStream e retorna como uma string
                            using (StreamReader
                            srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }
        private static byte[] DeriveKey(byte[] keyBytes, int keySize)
        {
            byte[] salt = Encoding.UTF8.GetBytes("MySaltValue");
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(keyBytes, salt, 10000))
            {
                return rfc2898DeriveBytes.GetBytes(keySize);
            }
        }
    }
}
