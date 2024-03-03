
namespace Homework_Namespace_DLL.Helpers.Extensions
{
    internal static class LoginExtensions
    {
        public static bool CheckEmail(this string email)
        {
            return email.Contains('@');
        }

        public static bool CheckPassword(this string password)
        {
            if(password.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
