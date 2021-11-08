using APPLib.Model.Interface;
using System;

namespace APPLib.Model
{
    public class Staff : User //coupling: Inheritance "Is a".
    {
        public Staff(string id, string name, IdCard idcard, string userType)
            : base(id, name, idcard, userType)
        {

        }
        public override bool OpenDoor(string IdCard)
        {
            Console.WriteLine("Openning Staff Room Door....");
            Console.WriteLine("Openning Dormitory Door....");
            return true;
        }
    }
}
