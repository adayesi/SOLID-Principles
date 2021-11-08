using System;
using System.Collections.Generic;
using System.Text;

namespace APPLib.Model.Interface
{
    public interface IUser
    {
        public string UserType { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdCard { get; set; }
        public bool Register();
        public bool Login();

    }
}
