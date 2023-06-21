using RegexRegistration;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Program
{
    public static void Main(String[] args)
    {
        Registration user = new Registration();

        // UC1 = Valid First Name.
        user.FirstName();

        // UC2 = Valid Last Name.
        user.LastName();

        // UC3 = Valid Email-Id.
        user.Email();

        // UC4 = Valid Phone Number.
        user.Number();

        // UC5 = Valid Password with Minimum 8 Characters.
        user.Password();

        // UC6 = Valid Password with at least 1 UpperCase Letter.
        user.Password2();

        // UC7 = Valid Password with at least 1 Numeric Number.
        user.Password3();



    }

}