using APPLib.Model;
using APPLib.Model.Interface;
using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser staff = new Staff("1", "Edward", null, "Staff");
            IUser student = new Staff("2", "Adayesi", null, "Student");
            //Console.WriteLine("Hello World!");
            Console.WriteLine($"Name {staff.Name}, Doors {staff.OpenDoor(null)}");
            Console.WriteLine($"Name {student.Name}, Doors {student.OpenDoor(null)}");
        }
    }
}
