using System;

namespace reverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int modNumber;
            Console.Write("Reverse of number you entered : ");
            while (number > 10)
            {
                modNumber = number % 10;
                Console.Write(modNumber);
                number = number / 10;
            }

            Console.Write(number);


            Console.ReadLine();
        }
    }
}
