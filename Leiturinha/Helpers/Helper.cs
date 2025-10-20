using System.Net.Mail;

namespace Leiturinha.Helpers;

public static class Helper
{
    // valida se o email é valido
    public static bool IsValidEmail(string email)
    {
        try
        {
            MailAddress m = new(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}