using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_in_the_classroom
{
    public interface IUser
    {
        void Login(string username, string password);

        string SendEmail(string email);
    }
}
