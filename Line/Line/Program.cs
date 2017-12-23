using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Line
{
    class Program
    {
        void Puzzle1()
        {
            List<int> sumNumbersMultiple = new List<int>();                             //Create a list to store the numbers to make the sum 
            int[] numbers = new int[1000];                                              //Create the array of all natural number
            for (int i = 0; i < numbers.Length; i++)                                    //Fill the array with 1000 natural numbers
                numbers[i] = i;
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 3 == 0 || numbers[i] % 5 == 0) && numbers[i] < 1000)  //Check if the number is a modulo of 3 and 5 and below 1000
                    sumNumbersMultiple.Add(numbers[i]);                                 //Add the number inside the liste
            }
            Console.WriteLine(sumNumbersMultiple.Sum());                                //Use Sum() function of the list to calculate de sum and show it
            Console.ReadLine();                                                                 
        }
        void Puzzle2()
        {
            int result = 0;             //Sum of the fib challenge
            int fib = 0;                //Original fib
            int fib1 = 1;               //Start fib
            int fib2 = 0;               //Fib to add to the previous fib
            while (fib < 4000000)   
            {
                fib = fib1 + fib2;      //Add the two fib together
                fib2 = fib1;            //Rearrange the fibs
                fib1 = fib;
                if (fib % 2 == 0)       //If the fib is a modulo of 2
                    result += fib;      //Add to the result
            }
            Console.WriteLine(result);  //Print the result
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            long number = 13195;
            long largestPrime = 0;
            for(long i = 1; i < number; i++)
            {
                if (number % i == 0)
                    largestPrime = i;
            }
            Console.WriteLine(largestPrime);
            Console.ReadLine();
        }
    }
}
