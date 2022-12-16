using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infinite.CSharp.Day15
{
    //Create a Delegate
    public delegate int operations(int a,int b);
    class ArithmeticOperations
    {
        public int AddNumbers(int num1, int num2)
        {
            Console.WriteLine("Addition is: " + (num1 + num2));
            return (num1 + num2);
        }

        public int MultiplyNumbers(int num1, int num2)
        {
            Console.WriteLine("Multiplication is: " + (num1 * num2));
            return (num1 * num2);
        }

        public int DivideNumbers(int num1, int num2)
        {
            Console.WriteLine("Division is: " + (num1 / num2));
            return num1 / num2;
        }

        public int SubtractNumbers(int num1, int num2)
        {
            Console.WriteLine("Subtraction is: " + (num1 - num2));
            return num1 - num2;
        }

        public int FindMaxNUmber(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("Max NUmber is: " + num1);
                return num1;
            }
            Console.WriteLine("Max Number is: " + num2);
            return num2;
        }
        static void Main1(string[] args)
        {
            ArithmeticOperations op = new ArithmeticOperations();


            Console.WriteLine("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Requried Arithmetic Operation ( Add, Multiply , Divide, Substract , FindMax)");
            string userchoice = Console.ReadLine();

            switch (userchoice)
            {
                case "Add":
                    operations Add = new operations(op.AddNumbers);
                    Add(num1, num2);
                    break;
                case "Multiply":
                    operations Multi= new operations(op.MultiplyNumbers);
                    Multi(num1, num2);
                    break;
                case "Divide":
                    operations Divide = new operations(op.DivideNumbers);
                    Divide(num1, num2);
                    break;
                case "Substract":
                    operations Subst = new operations(op.SubtractNumbers);
                    Subst(num1, num2);
                    break;
                case "FindMax":
                    operations Max = new operations(op.FindMaxNUmber);
                    Max(num1, num2);
                    break;                                  
            }
        }

    }
}
