using LoginExceptionProject.Auth;
using System;

namespace LoginExceptionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "h2oki";
            Account account = new Account();
            account.Login(password);
        }
    }
}
