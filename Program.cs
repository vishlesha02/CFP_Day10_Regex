using RegexRegistration;
using System.Globalization;

public class Program
{
    public static void Main(String[] args)
    {
        Registration user = new Registration();

        user.FirstName();

        user.LastName();

        user.Email();

        user.Number();

        user.Password();

    }

}