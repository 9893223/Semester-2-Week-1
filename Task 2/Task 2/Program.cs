using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {

         /*Task 2.
Create an app that can deal with storing information about a companies employees credentials. The app requires a custom object which can deal with the following employee information:

Full name
Phone number
Email address
Ird number
Bank account number
Computer system username
Computer system password
you need to ensure that the employees ird number and bank details are safe.

The company currently has 5 employees so use an array of to store the objects and
use a loop to get the user to input the required information to populate the array. 
Create a separate method to display all of the employees details back to the user formatted
so its easily read.*/

        static void Main(string[] args)
        {
            Employee[] people = new Employee[]
            {
                new Employee("Ben", "0277880136", "bderijk@hotmail.co.nz", "9023672", "98741874847", "benny", "1351")
        };

            foreach (Employee x in people)
            {
                Console.WriteLine($"Name={x.Name}\nPhone={x.Phone}\nEmail={x.Email}\nUsername={x.Compusername}\nPassword= {x.Comppassword}");

            }
            Console.ReadLine();

        }
        
            class Employee
        {
            //Attribues
            private string name;
            private string phone;
            private string email;
            private string irdnum;
            private string banknum;
            private string compusername;
            private string comppassword;
           

            //Getters and setters
            public string Name { get { return name; } set { name = value; } }
            public string Phone {  get { return phone; } set { phone = value; } }
            public string Email {  get { return email; } set { email = value; } }
            public string Irdnum { private get { return irdnum; } set { irdnum = value; } }
            public string Banknum { private get { return banknum; } set { banknum = value; } }
            public string Compusername { get { return compusername; } set { compusername = value; } }
            public string Comppassword { get { return comppassword; } set { comppassword = value; } }

          
            //Constructor
            public Employee(string _name, string _phone, string _email, string _irdnum, string _banknum, string _compusername, string _comppassword)
            {
                Name = _name;
                Phone = _phone;
                Email = _email;
                Irdnum = _irdnum;
                Banknum = _banknum;
                Compusername = _compusername;
                Comppassword = _comppassword;

            }
        }
    }
}
