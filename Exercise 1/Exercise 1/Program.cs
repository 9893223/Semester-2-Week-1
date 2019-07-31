using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {




             //Question 4
             //Write a program that takes two numbers as inputs and displays the product of the two numbers.



            /* Console.WriteLine("Please enter number 1:");
             int Num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Please enter number 2:");
             int Num2 = int.Parse(Console.ReadLine());

             Console.WriteLine($"\n{Q4(Num1,Num2)}");

             Console.ReadLine();


              string Q4(double num1, double num2)
             {
                 return $"{num1} x {num2} = {num1 * num2}";
             }



            //Write a program that takes a number as input and prints its multiplication table up to 10.

            Console.WriteLine("Please input a number:");
            int UserNum = int.Parse(Console.ReadLine());

            for (int i = 0; i <=10;i++)
            {
                Console.WriteLine($"\n{UserNum} x {i} = {UserNum * i}");
            }

            Console.ReadLine();


            //Write a program that takes in the radius and use it to calculate the area and perimeter of a circle.

            Console.WriteLine("Please enter the radius to show area of the circle:");
            double Num = double.Parse(Console.ReadLine());

            Console.WriteLine($"The perimeter of the circle = {Perimeter(Num)} and the area = {Area(Num)}");

            Console.ReadLine();

            string Perimeter(double num)
            {
                return $"{Math.PI * (num * 2)}";
            }

            string Area (double num)
            {
                return $"{Math.PI * (num*num)}";
            }



            //Write a program that can swap the values of two variables

            Console.WriteLine("This programm will swap 2 numbers");
            Console.WriteLine("Please input number 1:");
            double Num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input number 2:");
            double Num2 = double.Parse(Console.ReadLine());


            Console.WriteLine($"Before swap your first input is {Num1} and your second input is {Num2}");
            Console.Write($"After swap your first input is now {NumSwapA(Num1, Num2)} and your second iput is now {NumSwapB(Num1, Num2)}");

            Console.ReadLine();



            string NumSwapA(double num1, double num2)
            {

                return $"{num1 * num2 / num1}";
                  
                
            }

            string NumSwapB(double num1, double num2)
            {

                return $"{num1 * num2 / num2}";


            }*/


            //Create an app that has a class called Details and contains 4 attributes with the appropriate getter and setter 
            //methods(not auto implemented properties) for the following:

       class CreditCardDetails
        {
            private string name;
            private double card;
            private double pin;
            private double expiry;

            public string Name { get { return name; }set { name = value; } }
            public double Card { private get { return card; } set { card = value; } }
            public double Pin { private get { return pin; } set { pin = value; } }
            public double Expiry { get { return expiry; } set { expiry = value; } }

        }






        Console.ReadLine();
               

        }
    }
}
