using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MovieRentalSystem
{
    public class SignUp
    {
        public int NewUserSingUp(string username, string password)
        {
            Regex regex1 = new Regex(@"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)");
            if (regex1.Matches(username).Count == 0)
                return -1;

            Regex regex2 = new Regex(@"(^\w*([0-9]+[a-z]+[A-Z]+)|([0-9]+[A-Z]+[a-z]+)|([A-Z]+[a-z]+[0-9]+)|([A-Z]+[0-9]+[a-z]+)|([a-z]+[0-9]+[A-Z]+)|([a-z]+[A-Z]+[0-9]+)\w*$)");
            if (regex2.Matches(password).Count == 0)
                return -2;

            return 0;
        }
    }
}
