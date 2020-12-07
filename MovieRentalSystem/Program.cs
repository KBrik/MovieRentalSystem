using System;

namespace MovieRentalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SignUp su = new SignUp();
            Console.WriteLine(su.NewUserSingUp("user@gmail.com", "dffbhQdf2sdg"));
        }
    }
}
