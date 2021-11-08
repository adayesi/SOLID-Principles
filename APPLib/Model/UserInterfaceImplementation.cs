using System;
using System.Collections.Generic;
using System.Text;

namespace APPLib.Model
{
    class UserInterfaceImplementation : IUserInterfaceImplementation
    {
        public UserInterfaceImplementation()
        {
         }
        public string UserType { get; set ; }
        public string Id { get; set;}
        public string Name { get; set; }
        public string IdCard { get; set; }

        public bool Login()
        {
            throw new NotImplementedException();
        }

        public bool Register()
        {
            throw new NotImplementedException();
        }
        public abstract bool OpenDoor(string IdCard)
        {
            throw new NotImplementedException();
        }
    }
}
