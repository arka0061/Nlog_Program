using System;

namespace NLog_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Substract obj = new Substract();
            Console.WriteLine("Enter 2 numbers");
            int first_number = Convert.ToInt32(Console.ReadLine());
            int second_number = Convert.ToInt32(Console.ReadLine());
            Substract.Sub(first_number,second_number);
        }
    }
}
