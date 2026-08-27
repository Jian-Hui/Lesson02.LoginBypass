using System;
using System.Security.Cryptography;
using System.Text;

namespace Lesson02.LoginBypass
{
    internal static class CredentialValidator
    {
        private const string ExpectedUsername = "operator";
        private const string PasswordSalt = "ILSPY-LESSON-02";
        private const string ExpectedPasswordHash =
            "mxPOe8B4I/FzTDejvmwAEjUKFLm8GQog0Kc+Nv0EEE4=";

        public static bool Validate(string username, string password)
        {
            if (!string.Equals(
                username,
                ExpectedUsername,
                StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            string actualPasswordHash = ComputePasswordHash(password);

            return string.Equals(
                actualPasswordHash,
                ExpectedPasswordHash,
                StringComparison.Ordinal);
        }

        private static string ComputePasswordHash(string password)
        {
            byte[] input = Encoding.UTF8.GetBytes(
                password + "|" + PasswordSalt);

            using (SHA256 sha256 = SHA256.Create())
            {
                return Convert.ToBase64String(
                    sha256.ComputeHash(input));
            }
        }
    }
}
