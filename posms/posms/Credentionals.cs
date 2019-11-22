using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace posms
{
    [Serializable]
    class Credentionals
    {
        public string Login { get; }
        public string Password { get; }

        public Credentionals(string login, string password)
        {
            Login = GetHashString(login);
            Password = GetHashString(password);
        }

        private static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Credentionals)
            {
                Credentionals a = obj as Credentionals;


                return Login == a.Login && Password == a.Password;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Login.Length + Password.Length;
        }
    }
}
