using MentorOnDemand.BuisnessLayer.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.BuisnessLayer.Services
{
    public class LoginServices 
    {
        
        public bool SignIn(string UserName, string Password)
        {
            return true;
        }

        public bool SignUp(string Role, string UserName, string Password, long ContactNumber)
        {
            return true;
        }
    }
}
