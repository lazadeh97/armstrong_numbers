using System;

namespace armstrong_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number, digit, temp = 0;
            decimal sum = 0;

            for (int i = 1; i <= 10000; i++)
            {
                number = i;
                temp = number;
                do
                {
                    digit = temp % 10;
                    temp = Math.Floor(temp / 10);
                    sum = sum + (digit * digit * digit* digit);

                } while (temp>0);

                if (sum == number)
                {                   
                    Console.WriteLine(number + " - " + "This number is armstrong!");
                }
 
                sum = 0;
                number = 0;
                temp = 0;
            }
        }
    }
}
