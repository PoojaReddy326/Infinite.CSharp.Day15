using Infinite.CSharp.Day15;
using System;

namespace Infinite.CSharp.Day16
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Employee emp = new Employee();
            //emp.GetDetails();

            //var result = emp.Validate(emp.MobileNo);
            //if (result)
            //{
            //    emp.PrintDetails();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Mobile Number");
            //}
            string statement = "Hello World Welcome,to CSharp Learning.I live in chennai"; 
            Console.WriteLine($"No of Words :{statement.WordCount()}");

            string mobileNo = "789459200";

            var result = mobileNo.OnlyNumbers();

            if (result) 
            {
                Console.WriteLine("Valid Mobile No"); 
            } 
            else 
            { 
                Console.WriteLine("Invalid Mobile No"); 
            }
        }
    }
}