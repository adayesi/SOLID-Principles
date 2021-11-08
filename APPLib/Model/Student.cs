using APPLib.Model.Interface;
using System;

namespace APPLib.Model
{
    public class Student : User
    {
        public Student(string id, string name, IdCard idcard, string userType)
            :base(id, name, idcard, userType)
        {

        }
       public override bool OpenDoor(string IdCard)
        {
           
            Console.WriteLine("Openning Dormitory Door....");
            return true;
        }
    }
}
