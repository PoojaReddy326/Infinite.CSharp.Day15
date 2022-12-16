using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;



namespace Day16Assignment
{
    class Program
    {
        public class Supplier
        {
            public int SupplierId { get; set; }
            public string SupplierName { get; set; }
            public string City { get; set; }
            public string MobileNo { get; set; }
            public string EmailId { get; set; }



            public void AcceptDetails(int SupplierId, string SupplierName, string City, string MobileNo, string EmailId)
            {
                this.SupplierId = SupplierId;
                this.SupplierName = SupplierName;
                this.City = City;
                this.EmailId = EmailId;
            }
            public void DisplayDetails(Supplier s)
            {
                WriteLine($"Details are : \nSupplier Id : {s.SupplierId}\nSupplier Name : {s.SupplierName}\nCity : {s.City}\nMobile No : {s.MobileNo}\nEmail Id : {s.EmailId} ");
                WriteLine($"Details are being inserted into file name {s.City}");
                string fname = @"C:\C Sharp\" + s.City;
                FileStream fs = new FileStream(fname, FileMode.Append, FileAccess.Write);                
                StreamWriter sw = new StreamWriter(fs);

                try
                {
                    sw.WriteLine($"Details are : \nSupplier Id : {s.SupplierId}\nSupplier Name : {s.SupplierName}\nCity : {s.City}\nMobile No : {s.MobileNo}\nEmail Id : {s.EmailId} ");
                    WriteLine("Details are inserted into the file");
                    sw.Flush();
                }
                catch (IOException e)
                {
                    WriteLine($"Error : {e.Message}");
                }
                catch (Exception e)
                {
                    WriteLine($"Error : {e.Message}");
                }
                finally
                {
                    sw?.Close();
                    fs?.Close();
                }
            }
            public void DisplayDetailsFromFile(string city)
            {
                WriteLine($"Opening file {city}");
                string fname = @"C:\C Sharp\" + city;

                FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read);

                if (fs != null)
                {
                    StreamReader sr = new StreamReader(fs);
                    WriteLine("Details are : ");
                    string temp = sr.ReadToEnd();
                    WriteLine(temp);
                    sr.Close();
                    fs.Close();
                }
                else
                {
                    fs.Close();
                    WriteLine($"{city} file does not exists.");
                }
            }
        }
        static void Main(string[] args)
        {
            Supplier s = new Supplier();
            bool flag = true;
            int ch;
            
            do
            {
                WriteLine("Main Menu : ");
                WriteLine($"1: Add details\n2: Insert into the file \n3: Display from file \n4.End");
                ch = int.Parse(ReadLine());
                switch (ch)
                {
                    case 1:
                        WriteLine("Enter Supplier Id : ");
                        int id = int.Parse(ReadLine());
                        WriteLine("Enter Supplier Name : ");
                        string name = ReadLine();
                        WriteLine("Enter City : ");
                        string city = ReadLine();
                        WriteLine("Enter Mobile No : ");
                        string mobile = ReadLine();
                        WriteLine("Enter Email Id : ");
                        string email = ReadLine();
                        s.AcceptDetails(id, name, city, mobile, email);
                        WriteLine("--------------------------------------------------------------------------------------------------------");
                        break;

                    case 2:
                        s.DisplayDetails(s);
                        WriteLine("--------------------------------------------------------------------------------------------------------");
                        break;

                    case 3:
                        WriteLine("Enter the Name of the file to be opened :");
                        string find = ReadLine();
                        s.DisplayDetailsFromFile(find);
                        break;

                    case 4:
                        WriteLine("Programee Completed");
                        ReadLine();
                        flag = false;
                        break;

                    default:
                        WriteLine("Wrong input");
                        break;
                }
            }
            while (flag);
        }
    }
}