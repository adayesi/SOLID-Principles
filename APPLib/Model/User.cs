using APPLib.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace APPLib.Model
{
    public abstract class User : IUser, IPriviledgedUser
    {
        public string UserType { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdCard { get; set; } //coupling: compositional("has a") relationaship with IdCard class


        public User(string id, string name, IdCard idcard, string userType)
        {
            Id = id;
            Name = name;
            UserType = userType;

        }
        public bool Register()
        {
            Console.WriteLine("registering user....");
            return true;
        }
        public bool Login()
        {
            Console.WriteLine("Loggin in....");
            return true;
        }

        public abstract bool OpenDoor(string IdCard);
       
        //public abstract OpenDoor(string IdCard);

    }
}
