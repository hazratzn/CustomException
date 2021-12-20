using LoginExceptionProject.Constans;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginExceptionProject.Auth
{
    public class Account
    {
        public void Login (string password)
        {
            try
            {
                if (password.Length < 6)
                {
                    throw new Exception(Messages.PasswordMessage);
                }
                else
                {
                    Console.WriteLine("Valid password");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
