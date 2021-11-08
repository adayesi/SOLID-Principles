using System;
using System.Collections.Generic;
using System.Text;

namespace APPLib.Model
{
    public interface IUserInterfaceImplementation
    {
        public string UserType { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdCard { get; set; } //coupling: compositional("has a") relationaship with IdCard class


        //public User(string id, string name, IdCard idcard, string userType)
        //{
        //    Id = id;
        //    Name = name;
        //    UserType = userType;

        //}
        public bool Register();

        public bool Login();
        
        public abstract bool OpenDoor(string IdCard);
    }
}
