namespace Lesson02.LoginBypass
{
    internal static class LoginService
    {
        public static bool Authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return CredentialValidator.Validate(username, password);
        }
    }
}
