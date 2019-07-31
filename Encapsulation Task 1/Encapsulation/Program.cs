using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
/*TASK 1 

Build an application that use a custom class to hold credit card information. 
The class needs to have the necessary attributes and properties to store the following information:

Name on the credit card (the card holders name)
Credit card number
3 digit security number
Expiration date
The getters for the name and expiration date can be public but the credit card number and security numbers getters need to be private. 

Create a suitable interface to create an instance of the credit card class and input some test information.
Display the cards name and expiration date back to the user nicely formatted using the credit card object you created.*/
            
            Console.WriteLine("Please enter your full name:");
            string name = (Console.ReadLine());
            Console.WriteLine("Please enter your card number:");
            double card = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your pin:");
            double pin = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your card expiry date in the format dd/mm/yyyy:");
            double expiry = double.Parse(Console.ReadLine());

            CreditCardInfo p1 = new CreditCardInfo(name, card, pin, expiry);

            Console.WriteLine($"Name = {p1.Name}\nExpiry = {p1.Expiry}");

            p1.DisplayForbidden(p1);

            Console.ReadLine();
        
        }

        class CreditCardInfo
        {
            //Attribues
            private string name;
            private double card;
            private double pin;
            private double expiry;

            //Getters and setters
            public string Name { get { return name; } set { name = value; } }
            public double Card { private get { return card; } set { card = value; } }
            public double Pin { private get { return pin; } set { pin = value; } }
            public double Expiry { get { return expiry; } set { expiry = value; } }

            //Constructor
            public CreditCardInfo(string _name, double _card, double _pin, double _expiry )
            {
                Name = _name;
                Card = _card;
                Pin = _pin;
                Expiry = _expiry;
            }

            //This allows the private acess attributes to be accessed within the class.
            public void DisplayForbidden(CreditCardInfo p1)
            {
                Console.WriteLine(p1.Card);
            }


        }
    }
}
