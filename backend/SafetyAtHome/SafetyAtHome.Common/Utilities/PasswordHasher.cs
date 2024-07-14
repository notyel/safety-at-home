using System;
using System.Security.Cryptography;

namespace SafetyAtHome.Common.Utilities
{
    public class PasswordHasher
    {
        public const int SaltSize = 16; // 128 bit
        public const int KeySize = 32; // 256 bit
        public const int Iterations = 10000;
        public const char Delimiter = ';';

        public string Hash(string password)
        {
            using (var algorithm = new Rfc2898DeriveBytes(
                password,
                SaltSize,
                Iterations,
                HashAlgorithmName.SHA256))
            {
                var key = Convert.ToBase64String(algorithm.GetBytes(KeySize));
                var salt = Convert.ToBase64String(algorithm.Salt);

                return $"{Iterations}{Delimiter}{salt}{Delimiter}{key}";
            }
        }

        public bool Check(string hash, string password)
        {
            var parts = hash.Split(Delimiter);
            var iterations = Convert.ToInt32(parts[0]);
            var salt = Convert.FromBase64String(parts[1]);
            var key = Convert.FromBase64String(parts[2]);

            using (var algorithm = new Rfc2898DeriveBytes(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256))
            {
                var keyToCheck = algorithm.GetBytes(KeySize);

                return keyToCheck.SequenceEqual(key);
            }
        }
    }
}
