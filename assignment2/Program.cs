using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 1: Multiplication table of a given number
            //Console.WriteLine("Enter a number");//input a number
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{number}*{i}={number * i}");
            //}
            //Console.ReadLine();

            //Lab:2 Display a right-angled triangle
            //Console.WriteLine("No.of rows");//input a no.of rows
            //int row = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Lab 3: Sum of all even numbers between 1 and 100
            //int i = 0;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    sum = sum + i;
            //    i += 2;
            //}
            //Console.WriteLine($"sum {sum}");
            //Console.ReadLine();

            //Lab 4: Multiplication table from 1 to 5
            //int i = 1;
            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= 10)
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j}");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //Console.ReadLine();

            //Lab 5: Print Positive Number
            //while (true)
            //{
            //    Console.WriteLine("Enter a number");//input a number
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    if (number > 0)
            //    {
            //        Console.WriteLine($"you entered postive number {number}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("negative number");
            //        break;
            //    }
            //}
            //Console.ReadLine();


            //Lab 6: Create Menu Driven Calculator
            //do
            //{
            //    Console.WriteLine(" 1.addition \n2.Substarction \n3.Multiplication \n4.Division \n5.Exit \nEnter your choice");
            //    string choice = Console.ReadLine();

            //    if (choice == "5")
            //    {
            //        Console.WriteLine("exit");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter the first number:");
            //        int firstNumber = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Enter the second number:");
            //        int secondNumber = Convert.ToInt32(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case "1":
            //                Console.WriteLine($"sum {firstNumber + secondNumber}");
            //                break;
            //            case "2":
            //                Console.WriteLine($"difference {firstNumber - secondNumber}");
            //                break;
            //            case "3":
            //                Console.WriteLine($"multiplication {firstNumber * secondNumber}");
            //                break;
            //            case "4":
            //                if (secondNumber == 0)
            //                {
            //                    Console.WriteLine("division by zero is invalid");

            //                }
            //                else
            //                {
            //                    double division = firstNumber / secondNumber;
            //                    Console.WriteLine($"multiplication {division}");
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("invalid");
            //                break;
            //        }
            //    }

            //}
            //while (true);
            //Console.ReadLine();


            //Lab 7: Print All Numbers From 1 to 100
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i == 51)
            //    {
            //        break;
            //    }
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //Lab 8: Sum of Odd Numbers
            //int sum=0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }    
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //Lab 9: calculate the factorial of a given number using a while loop.
            //Console.WriteLine("Enter a number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;

            //while (number > 0)
            //{
            //    factorial *= number;
            //    number--;
            //}

            //Console.WriteLine("Factorial: " + factorial);
            //Console.ReadLine();

            //10 Write a C# program to print a number pyramid using a nested while loop.
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(i + 1);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //11 Guess the Number Game

            //int originalNumber=new Random().Next(1,101);
            //Console.WriteLine(originalNumber);

            //bool value=true;
            //while(value)
            //{ 
            //    Console.WriteLine("Enter your guess");
            //    int guesNumber=Convert.ToInt32(Console.ReadLine());

            //    if ( guesNumber == originalNumber )
            //    {
            //        Console.WriteLine("you win");
            //        value=false;
            //        break;
            //    }
            //    else if ( guesNumber < originalNumber )
            //    {
            //        Console.WriteLine("loo low,guess again");
            //    }
            //    else if( guesNumber > originalNumber )
            //    {
            //        Console.WriteLine("too high");
            //    }
            //}
            //Console.ReadLine();

            //Lab 12: Simple Calculator

            //do
            //{
            //    Console.WriteLine(" 1.addition \n2.Substarction \n3.Multiplication \n4.Division \n5.Exit \nEnter your choice");
            //    string choice= Console.ReadLine();

            //    if (choice == "5")
            //    {
            //        Console.WriteLine("exit");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter the first number:");
            //        int firstNumber = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Enter the second number:");
            //        int secondNumber = Convert.ToInt32(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case "1":
            //                Console.WriteLine($"sum {firstNumber + secondNumber}");
            //                break;
            //            case "2":
            //                Console.WriteLine($"difference {firstNumber - secondNumber}");
            //                break;
            //            case"3":
            //                Console.WriteLine($"multiplication {firstNumber * secondNumber}");
            //                break;
            //            case "4":
            //                if (secondNumber == 0)
            //                {
            //                    Console.WriteLine("division by zero is invalid");

            //                }
            //                else
            //                {
            //                    double division = firstNumber / secondNumber;
            //                    Console.WriteLine($"multiplication {division}");
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("invalid");
            //                break;
            //        }
            //    }

            //}
            //while(true);
            //Console.ReadLine();

            //13 accepts a number from the user and calculates the sum of its digits using a do -while loop.
            //Console.WriteLine("Enter a number ");
            //int number=Convert.ToInt32(Console.ReadLine());
            //int remainder;
            //int sum = 0;
            //do
            //{
            //    remainder = number % 10;  
            //    sum += remainder;         
            //    number /= 10;             
            //} 
            //while (number != 0);

            //Console.WriteLine($"sum of digits {sum}");
            //Console.ReadLine();


            //14 accepts 10 numbers from the user and finds the largest number using a for loop.
            //int[] num = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(num);
            //Console.WriteLine($"largest number is {num[9]}");

            //Console.ReadLine(); 

            //15 the sum of squares of all numbers from 1 to a user-provided number using a while loop.
            //Console.WriteLine("Enter a number");
            //int number=Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //while (i<= number)
            //{
            //    Console.WriteLine($"square of {i}: {i*i}");
            //    i++;
            //}
            //Console.ReadLine();

            //16 countdown timer from 10 to 1 using a do-while loop, displaying each second.

            //int i = 10;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //    Thread.Sleep(1000);
            //}
            //while (i > 0);
            //Console.ReadLine();

            //17 Finding the First Multiple of 5 

            //int[] num = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int multipleOfFive = -1;
            //for (int i = 0;i < num.Length; i++) 
            //{
            //    if (num[i] % 5 == 0)
            //    {
            //            multipleOfFive = num[i];
            //        break;  
            //    }
            //}

            //// Check if a multiple of 5 was found
            //if (multipleOfFive != -1)
            //{
            //    Console.WriteLine("The first multiple of 5 is: " + multipleOfFive);
            //}
            //else
            //{
            //    Console.WriteLine("No multiple of 5 found in the list.");
            //}
            //Console.ReadLine();

            //18 Print Non-Multiples of 3 
            //for (int i=0;i<20;i++)
            //{
            //    if( i %3==0 )
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine() ;

            //19 Checking for Palindrome 

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int originalNumber = number;
            //int reversedNumber = 0;

            //while (number > 0)
            //{
            //    int remainder = number % 10;
            //    reversedNumber = (reversedNumber * 10) + remainder;
            //    number /= 10;
            //}

            //if (originalNumber == reversedNumber)
            //{
            //    Console.WriteLine($"{originalNumber} is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine($"{originalNumber} is not a palindrome.");
            //}

            //Lab 20: Average of Positive Numbers  

            //int sum = 0, count = 0;
            //int number;

            //do
            //{
            //    Console.Write("Enter a number (negative to stop): ");
            //    number = int.Parse(Console.ReadLine());

            //    if (number >= 0)
            //    {
            //        sum += number;
            //        count++;
            //    }

            //} while (number >= 0);

            //if (count > 0)
            //{
            //    double average = (double)sum / count;
            //    Console.WriteLine("Average of positive numbers: " + average);
            //}
            //else
            //{
            //    Console.WriteLine("No positive numbers were entered.");
            //}

            //Lab 21: Reverse a Number 

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int reversedNumber = 0;

            //do
            //{
            //    int remainder = number % 10;
            //    reversedNumber = (reversedNumber * 10) + remainder;
            //    number /= 10;

            //} while (number > 0);

            //Console.WriteLine("Reversed number: " + reversedNumber);

            ////22   Menu-Driven String Operations 
            ///
            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();
            //int choice;

            //do
            //{
            //    Console.WriteLine("\nMenu:");
            //    Console.WriteLine("1. Reverse the string");
            //    Console.WriteLine("2. Convert to uppercase");
            //    Console.WriteLine("3. Convert to lowercase");
            //    Console.WriteLine("4. Find the length of the string");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            char[] charArray = inputString.ToCharArray();
            //            Array.Reverse(charArray);
            //            Console.WriteLine("Reversed string: " + new string(charArray));
            //            break;

            //        case 2:
            //            Console.WriteLine("Uppercase string: " + inputString.ToUpper());
            //            break;

            //        case 3:
            //            Console.WriteLine("Lowercase string: " + inputString.ToLower());
            //            break;

            //        case 4:
            //            Console.WriteLine("Length of the string: " + inputString.Length);
            //            break;

            //        case 5:

            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice. Please try again.");
            //            break;
            //    }

            //} while (choice != 5);

            //Lab 23: Skip Multiples of 4 

            //for (int i = 0; i <= 50; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //Lab 24: Fibonacci Sequence  

            //int n1 = 0, n2 = 1, n3;
            //Console.WriteLine("First 10 numbers in Fibonacci sequence:");

            //Console.Write(n1 + " " + n2 + " ");  

            //for (int i = 2; i < 10; i++)  
            //{
            //    n3 = n1 + n2;
            //    Console.Write(n3 + " ");
            //    n1 = n2;
            //    n2 = n3;
            //}

            //Lab 25: Find All Armstrong Numbers  
            //Console.WriteLine("Armstrong numbers between 1 and 500:");

            //for (int number = 1; number <= 500; number++)
            //{
            //    int sumOfCubes = 0;
            //    int temp = number;

            //    while (temp > 0)
            //    {
            //        int digit = temp % 10;
            //        sumOfCubes += digit * digit * digit;
            //        temp /= 10;
            //    }

            //    if (sumOfCubes == number)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //Lab 26: Menu-Driven Number System Conversion 

            //int choice;

            //do
            //{
            //    Console.WriteLine("\nMenu:");
            //    Console.WriteLine("1. Binary to Decimal");
            //    Console.WriteLine("2. Decimal to Binary");
            //    Console.WriteLine("3. Decimal to Hexadecimal");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter a binary number: ");
            //            string binaryNumber = Console.ReadLine();
            //            int decimalValue = Convert.ToInt32(binaryNumber, 2);
            //            Console.WriteLine("Decimal value: " + decimalValue);
            //            break;

            //        case 2:
            //            Console.Write("Enter a decimal number: ");
            //            int decimalNumber = int.Parse(Console.ReadLine());
            //            string binaryValue = Convert.ToString(decimalNumber, 2);
            //            Console.WriteLine("Binary value: " + binaryValue);
            //            break;

            //        case 3:
            //            Console.Write("Enter a decimal number: ");
            //            decimalNumber = int.Parse(Console.ReadLine());
            //            string hexValue = Convert.ToString(decimalNumber, 16);
            //            Console.WriteLine("Hexadecimal value: " + hexValue.ToUpper());
            //            break;

            //        case 4:

            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice. Please try again.");
            //            break;
            //    }

            //} while (choice != 4);

            //Lab 27: Reverse a String

            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();
            //string reversedString = "";

            //for (int i = inputString.Length - 1; i >= 0; i--)
            //{
            //    reversedString += inputString[i];
            //}

            //Console.WriteLine("Reversed string: " + reversedString);

            //Lab 28: Count Vowels and Consonants in a String  

            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine().ToLower();

            //int vowelCount = 0, consonantCount = 0;

            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    char ch = inputString[i];
            //    if ("aeiou".Contains(ch))
            //    {
            //        vowelCount++;
            //    }
            //    else if (char.IsLetter(ch))
            //    {
            //        consonantCount++;
            //    }
            //}

            //Console.WriteLine("Number of vowels: " + vowelCount);
            //Console.WriteLine("Number of consonants: " + consonantCount);

            //Lab 29: Find Maximum and Minimum 

            //int[] numbers = new int[5];

            //Console.WriteLine("Enter 5 numbers:");
            //for (int i = 0; i < 5; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int max = numbers[0];
            //int min = numbers[0];

            //for (int i = 1; i < 5; i++)
            //{
            //    if (numbers[i] > max)
            //        max = numbers[i];
            //    if (numbers[i] < min)
            //        min = numbers[i];
            //}

            //Console.WriteLine("Maximum number: " + max);
            //Console.WriteLine("Minimum number: " + min);

            //Lab 30: Count Digits of a Number 

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int digitCount = 0;

            //while (number != 0)
            //{
            //    number /= 10;
            //    digitCount++;
            //}

            //Console.WriteLine("Number of digits: " + digitCount);

            Console.ReadLine();
        }

    }
}

