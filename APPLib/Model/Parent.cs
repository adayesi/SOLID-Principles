using APPLib.Model.Interface;
using System;

namespace APPLib.Model
{
    public class Parent : IUser
    {
       

        public bool Login()
        {
            Console.WriteLine("Loggin in....");
            return true;
        }

        public bool Register()
        {
            Console.WriteLine("registering user....");
            return true;
        }
    }
}
