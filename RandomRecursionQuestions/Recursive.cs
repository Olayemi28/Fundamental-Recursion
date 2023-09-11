using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
   public class Recursive
   {
        static int increment = 1;
        static int sum;
        static int count;

        //1. Write a program in C# Sharp to print the first n natural number using recursion.
       public static int NaturalNumber(int number)
       {
            if (number < 1)
            {
                return 1;
            }
            number--;
            Console.Write(increment + " ");
            increment++;
            return NaturalNumber(number);
       }

        //2. Write a program in C# Sharp to print numbers from n to 1 using recursion.
       public static int NaturalNumberInReversedOrder(int number)
       {
            if (number < 1)
            {
                return 1;
            }
            Console.Write(number + " ");
            number--;
            return NaturalNumberInReversedOrder(number);
       }

        //3. Write a program in C# Sharp to find the sum of first n natural numbers using recursion.
       public static int SumUpNaturalNumbers(int number)
       {
            if (number < 1)
            {
                return sum;
            }
            number--;
            sum += increment;
            increment++;
            return SumUpNaturalNumbers(number);

       }

        //4. Write a program in C# Sharp to display the individual digits of a given number using recursion.
       public static void IndividualDigits(int number)
       {
            if (count > 0)
            {
                return;
            }
            IndividualDigits2(number);
            IndividualDigits(number);
       }
       public static void IndividualDigits2(int number)
       {
            string value = number.ToString();
            char[] split = value.ToCharArray();
            foreach (var item in split)
            {
                Console.Write(item + " ");
                count++;
            }
       }

        //5. Write a program in C# Sharp to count the number of digits in a number using recursion.
       public static int CountOfDigits(int number)
       {
            if (count > 0)
            {
                return count;
            }
            IndividualDigits2(number);
            return CountOfDigits(number);
       }

        //6. Write a program in C to print even or odd numbers in a given range using recursion.
       public static void PrintEvenOrOdd()
       {
            Console.Write("Even numbers: ");
            PrintEvenNumber(6, 20);
            Console.WriteLine();
            Console.Write("Odd numbers: ");
            PrintOddNumber(6, 20);
       }
       public static void PrintEvenNumber(int smaller, int bigger)
       {
            if (bigger < smaller)
            {
                return;
            }
            if (smaller % 2 == 0)
            {
                Console.Write(smaller + " ");
            }
            smaller++;
            PrintEvenNumber(smaller, bigger);
       }
       public static void PrintOddNumber(int starting, int ending)
       {
            if (ending < starting)
            {
                return;
            }
            if (starting % 2 != 0)
            {
                Console.Write(starting + " ");
            }
            starting++;
            PrintOddNumber(starting, ending);
       }

        //7. Write a program in C# to check whether a number is prime or not using recursion.
        static int increment1 = 1;
        static int count1;
        public static void PrintPrime(int number)
        { 
            if(increment1 >= number)
            {
                if(count1 == 2)
                {
                    Console.WriteLine(number + " " + "is a prime number.");
                    return;
                }
            }
            if(number % increment1 == 0)
            {
                count1++;
                if (count1 > 2)
                {
                    Console.WriteLine(number + " " + "is not a prime number.");
                    return;
                }
            }
            increment1++;
            PrintPrime(number);
        }

        static int i;
        static bool isPalindrome;
        //8. Write a program in C# to check whether a string is palindrome or not using recursion.
        public static bool PrintPalindrome(string word)
        {
            char[] letters = word.ToCharArray();
            char[] reverse = word.Reverse().ToArray();
            
            if (letters.Length - 1 <= i)
            {
                if (letters[i] == reverse[i])
                {
                    return isPalindrome = true;
                }
            }
            
            if (letters[i] != reverse[i])
            {
               return isPalindrome;
            }
            i++;
            return PrintPalindrome(word);
        }

        static BigInteger factorial = 1;
        //9. Write a program in C# to find the factorial of a given number using recursion.
        public static BigInteger PrintFactorial(int number)
        {
            if (number < 1)
            {
                return factorial;
            }
            
           factorial *= number;
           return PrintFactorial(number - 1);
        }

        static int a;
        static int b = 1;
        static int c;
        static int counter = 1;
        //10. Write a program in C# to find the fibonacci numbers for a N numbers using recursion.
        public static void FindFibonacci(int number)
        {
            if (number == counter)
            {
                return;
            }

            if (number > 2)
            {
                if (counter == 1)
                {
                    Console.Write(0 + " ");
                }
                a = b;
                b = c;
                c = a + b;
                counter++;
            }
            Console.Write(c + " ");
            FindFibonacci(number);
        }

        static int k;
        static int currentCount = 1;
        //11. Write a program in C# to generate all possible permutation of an array using recursion.
        public static void PrintPermutation(int[] array)
        {
            int i;
            if (k == array.Length - 1)
            {
                for (i = 0; i <= array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}");
                }
                Console.Write(" ");
                k = 1;
            }
            else
            {
                for (i = k; i <= array.Length - 1; i++)
                {
                    SwapNumbers(ref array[k], ref array[i]);
                    k++;
                    PrintPermutation(array);
                    SwapNumbers(ref array[k], ref array[i]);
                }
            }
        }




        public static void SwapNumbers(ref int num1, ref int num2)
        {
            int num3 = num1;
            num1 = num2;
            num2 = num3;
        }


        public void swapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void prnPermut(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                    Console.Write("{0}", list[i]);
                Console.Write(" ");
            }
            else
                for (i = k; i <= m; i++)
                {
                    swapTwoNumber(ref list[k], ref list[i]);
                    prnPermut(list, k + 1, m);
                    swapTwoNumber(ref list[k], ref list[i]);
                }
        }


        static int min;
        static int j = 1;
        static int max;
        
        //12. Write a program in C# to find the LCM and GCD of two numbers using recursion.
        public static void PrintLCMandGCD(int num1, int num2)
        {
            if (num1 < num2)
            {
                min = num1;
            }
            else
            {
                min = num2;
            }

            if (num1 % j == 0 && num2 % j == 0)
            {
                if (j > max)
                {
                    max = j;
                }
            }

            if (j == min)
            {
                Console.WriteLine($"LCM = {(Math.Abs(num1 * num2) / max)}, GCD = {max}");
                return;
            }
            j++;
            PrintLCMandGCD(num1, num2);
        }

        static List<long> save = new List<long>();
        static long remainder;
        
        //13. Write a program in C# to convert from decimal to binary using recursion.
        public static void ConvertDecimalToBinary(int number)
        {
            if (number < 1)
            {
                save.Reverse();
                Console.Write(string.Join(" ", save));
                return;
            }

            remainder = number % 2;
            save.Add(remainder);
            number = number / 2;
            ConvertDecimalToBinary(number);
        }

        static int iteration;
        static int counting;
        //14. Write a program in C# to get reverse string using recursion.
        public static void ReversedWord(string word)
        {
            char[] split = word.ToCharArray();
            iteration = split.Length - 1;
            if (counting == split.Length)
            {
                return;
            }
            iteration = iteration - counting;
            Console.Write(split[iteration]);
            counting++;
            ReversedWord(word);
        }

        static int result = 1;
        //15. Write a program in C# to calculate the power of any number using recursion.
        public static int CalculatePower(int number, int power)
        {
            if (power < 1)
            {
                return result;
            }
            result *= number;
            power--;
            return CalculatePower(number, power);
        }
   }
}
