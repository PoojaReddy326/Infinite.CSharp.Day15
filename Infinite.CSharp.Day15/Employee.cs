using System;
using static System.Console;

namespace Infinite.CSharp.Day15
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }

        public void GetDetails()
        {
            Write("Enter Employee Id :");
            Id = int.Parse(ReadLine());
            Write("Enter Employee Name :");
            Name = ReadLine();
            Write("Enter Mobile No :");
            MobileNo = ReadLine();
        }

        public void PrintDetails()
        {
            WriteLine($"Employee Id :{Id}\nName :{Name}\nMobile No :{MobileNo}");
        }
    }

}
