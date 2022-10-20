using Practice_in_the_classroom.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_in_the_classroom.Services.Implementation
{
   public class AccountService : IAccountService
    {
        public void Register()
        {
            Console.WriteLine("Already registered");   
        }
    }
}
