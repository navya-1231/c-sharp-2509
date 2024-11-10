using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_Arrays_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Array Manipulations

            //Assignment 1.Write C# programs on Matrix addition, Matrix Multiplication and Matrix Transpose. 


            ////matrix 1
            //int[,] matrix1 = new int[3, 3] { { 1, 2, 5 }, { 2, 3, 6 }, { 3, 4, 7 } };

            //Console.WriteLine("matrix 1");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrix1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            ////matrix2
            //int[,] matrix2 = new int[3, 3] { { 5, 6, 1 }, { 7, 8, 3 }, { 9, 10, 2 } };

            //Console.WriteLine("matrix 2");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrix2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            ////Matrix Multiplication
            //int[,] add_result = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        add_result[i, j] = matrix1[i, j] + matrix2[i, j];
            //    }
            //}
            //Console.WriteLine("matrix addition result");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(add_result[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            ////Matrix Transpose
            //int[,] transpose_result = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        transpose_result[j, i] = matrix1[i, j];
            //    }
            //}
            //Console.WriteLine("Matrix Transpose of matrix 1");


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(transpose_result[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            ////Matrix Multiplication

            //int[,] multiplication_result = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            multiplication_result[i, j] += matrix1[i, k] * matrix2[k, j];
            //        }
            //    }
            //}
            //Console.WriteLine("Matrix Multiplication");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(multiplication_result[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //Console.ReadLine();


            //----------------------------------------------------------------------------------------------

            //Assignment 2.Write C# programs to sort an array using bubble sort and insertion sort. 

            //int[] array = new int[] { 31, 6, 17, 8, 9, 15, 1, 2 };

            ////using bubble sort-compares adjacent elements, and swaps

            //int length = array.Length;

            //for (int i = 0; i < length - 1; i++)
            //{
            //    for (int j = 0; j < length - 1; j++)
            //    {
            //        // Swap if the element found is greater than the next element
            //        if (array[j] > array[j + 1])
            //        {
            //            int temp = array[j];
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("sorted array using bubble sort");
            //foreach (int num in array)
            //{
            //    Console.Write(num + " ");
            //}


            ////using insertion sort-

            //int[] array1 = new int[] { 31, 6, 17, 8, 9, 15, 1, 2 };

            //for (int i = 1; i < length; i++)
            //{
            //    int key = array1[i];
            //    int j = i - 1;

            //    // Move elements  that are greater than key to one position ahead
            //    while (j >= 0 && array1[j] > key)
            //    {
            //        array1[j + 1] = array1[j];
            //        j = j - 1;
            //    }
            //    array1[j + 1] = key;
            //}
            //Console.WriteLine("\nsorted array using insertion sort");
            //foreach (int num in array1)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.ReadLine();



            //----------------------------------------------------------------------------------------------
            //Assignment 3.Write C# programs to search an array using linear search and binary search.
            //

            //int[] array1 = { 2, 4, 6, 8, 10, 12 };
            //int target = 8;

            //SearchAlgorithms.LinearSearch(array1, target);

            //SearchAlgorithms.BinarySearch(array1, target);

            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------
            //Assignment 4.Array Calculations: write C# programs for finding median, mode value, highest, second highest and duplicate elements in an array

            //int[] array1 = { 2, 3, 4, 6, 8, 10, 12, 12, 9 };

            //Array.Sort(array1);
            //foreach (int num in array1)
            //{
            //    Console.Write(num + " ");
            //}
            //ArrayCalculations.FindMedian(array1);
            //ArrayCalculations.FindMode(array1);
            //ArrayCalculations.HighestAndSecondHighest(array1);

            //ArrayCalculations.FindDuplicate(array1);
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------
            //Assignment 5.Write a C# programs to count vowels, consonants and special characters. 

            //string string1 = "Navya@S";
            //string str = string1.ToLower();
            //int vowelCount = 0;
            //int consonantsCount = 0;
            //int specialCharacter = 0;


            //foreach (char c in str)
            //{
            //    if (char.IsLetter(c))
            //    {
            //        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //        {
            //            vowelCount++;
            //        }
            //        else
            //        {
            //            consonantsCount++;
            //        }
            //    }
            //    else
            //    {
            //        specialCharacter++;
            //    }
            //}
            //Console.WriteLine($"vowel count {vowelCount}\nconsonants count {consonantsCount}\nspecial character count {specialCharacter}");
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------
            //Assignment 6. Write a C# program to reverse a string. 

            //String string1 = "English";
            //String reversedString = "";
            //Console.WriteLine(string1.Length);
            ////iterate through last elemnt to first element
            //for (int i = string1.Length - 1; i >= 0; i--)
            //{
            //    reversedString = reversedString + string1[i];
            //}
            //Console.WriteLine(reversedString);

            //Console.ReadLine();


            ////----------------------------------------------------------------------------------------------
            //////Assignment 7.Write a C# program to find substring occurrence within a main string.  

            //string mainString = "hello world hello";
            //string subString = "hello";

            //int mainLength = mainString.Length;
            //int subLength = subString.Length;

            //int count = 0;


            //for (int i = 0; i <= mainLength - subLength; i++)
            //{
            //    //Check if the substring starting at index i matches the target substring

            //    if (mainString.Substring(i, subLength) == subString)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("String: " + mainString);
            //Console.WriteLine("substring: " + subString);
            //Console.WriteLine("count of substring: " + count);

            //Console.ReadLine();
            //----------------------------------------------------------------------------------------------

            //Assignment 8.Write a C# program to convert string to uppercase, lowercase, and title case. 

            //String string1 = "English";

            //// Convert to uppercase
            //string upperCase = string1.ToUpper();
            //Console.WriteLine("Uppercase: " + upperCase);

            //// Convert to lowercase
            //string lowerCase = string1.ToLower();
            //Console.WriteLine("Lowercase: " + lowerCase);

            ////convert to title case
            //TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            //string titleCase = ti.ToTitleCase(lowerCase);
            //Console.WriteLine("Title case: " + titleCase);

            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------
            //Assignment 9.Write a C# program to remove whitespace from a string. 

            //String string1 = "Navya Saju";

            //string string2 = string1.Replace(" ", "");

            //Console.WriteLine(string2);

            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------
            //Assignment 10.Write a C# program to replace all occurrences of a substring. 

            //string mainString = "hy hello hy";

            //string substring = "hy";

            //string replaceString = "world";

            //string result = mainString.Replace(substring, replaceString);

            //Console.WriteLine($"original string: {mainString}");
            //Console.WriteLine($"substring :{substring}");
            //Console.WriteLine($"replace with :{replaceString}");
            //Console.WriteLine($"result: {result}");

            //Console.ReadLine();


            //----------------------------------------------------------------------------------------------
            ////Assignment 11.Write a C# program to find the longest word in a sentence. 


            //String string1 = "hy helloooo world";

            //string[] words = string1.Split(' ');

            //string longWord = "";
            //int maxLength = 0;


            //foreach (string word in words)
            //{
            //    if (word.Length > maxLength)
            //    {
            //        maxLength = word.Length;
            //        longWord = word;
            //    }
            //}
            //Console.WriteLine($"original string:{string1}");
            //Console.WriteLine($"maximun length word:{longWord}");
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------
            //Assignment 12.Write a C# program to count words in a sentence.

            //String string1 = "Hello how are you";
            //int wordCount = 0;
            //string[] stringArray = string1.Split(' ');

            //wordCount = stringArray.Length;
            //Console.WriteLine("string: " + string1);
            //Console.WriteLine("word count: " + wordCount);

            //Console.ReadLine();


            //----------------------------------------------------------------------------------------------
            //Assignment 13.Write a C# program to remove duplicate characters from a string. 

            //String string1 = "Hello";

            //String resultString = "";

            //for (int i = 0; i < string1.Length; i++)
            //{
            //    if (!resultString.Contains(string1[i]))
            //    {
            //        resultString += string1[i];
            //    }
            //}
            //Console.WriteLine("original string: " + string1);
            //Console.WriteLine("result: " + resultString);
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------
            //Assignment 14.Write a C# program to check if two strings are anagrams. 

            //String string1 = "Mug";

            //String string2 = "Gum";

            //// Convert strings to lowercase 
            //string1 = string1.ToLower();
            //string2 = string2.ToLower();

            //// Convert strings to character arrays
            //char[] s1Array = string1.ToCharArray();
            //char[] s2Array = string2.ToCharArray();

            //// Sort the character arrays
            //Array.Sort(s1Array);
            //Array.Sort(s2Array);

            //// Compare the sorted arrays
            //bool areAnagrams = s1Array.SequenceEqual(s2Array);

            //if (areAnagrams)
            //{
            //    Console.WriteLine($"{string1} and {string2} are anagrams.");
            //}
            //else
            //{
            //    Console.WriteLine($"{string1} and {string2} are not anagrams.");
            //}

            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------


            //Assignment 15.Write a C# program to find the frequency of each character in a string.
            //

            //String string1 = "Malayalam";
            //Dictionary<char, int> frequency = new Dictionary<char, int>();

            //foreach (char c in string1.ToLower())
            //{
            //    if (frequency.ContainsKey(c))
            //    {
            //        frequency[c]++;
            //    }
            //    else
            //    {
            //        frequency[c] = 1;
            //    }

            //}
            //Console.WriteLine("string: " + string1);
            ////Print the frequency of each character
            //Console.WriteLine("Character frequencies:");
            //foreach (var keyValue in frequency)
            //{
            //    Console.WriteLine($"Character '{keyValue.Key}': {keyValue.Value}");
            //}
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------

            //Assignment 16.Write a C# program to find the first non-repeating character in a string. 

            //String string1 = "Hello Hy";
            //Dictionary<char, int> frequency = new Dictionary<char, int>();

            //// Count the frequency of each character
            //foreach (char c in string1.ToLower())
            //{
            //    if (frequency.ContainsKey(c))
            //    {
            //        frequency[c]++;
            //    }
            //    else
            //    {
            //        frequency[c] = 1;
            //    }

            //}
            //Console.WriteLine("string: " + string1);

            //// Print the first non repeating character 

            //foreach (char c in string1.ToLower())
            //{
            //    if (frequency[c] == 1)
            //    {
            //        Console.WriteLine("First non-repeating character: " + c);
            //        break;
            //    }
            //}

            //Console.ReadLine();


            //----------------------------------------------------------------------------------------------

            //Assignment 17.Write a C# program to reverse words in a sentence. 


            //string sentence = "HY HELLO";
            //Console.WriteLine("Original sentence " + sentence);
            //// Split the sentence into words
            //string[] words = sentence.Split(' ');

            //// Reverse the order of the words
            //Array.Reverse(words);

            //// Join the reversed words into a new sentence
            //string reversedSentence = string.Join(" ", words);

            //Console.WriteLine("Reversed sentence:" + reversedSentence);


            //Console.ReadLine();


            //----------------------------------------------------------------------------------------------


            //Assignment 18.Write a C# program to check if a string contains only digits. 


            //Console.WriteLine("Enter a string");
            //string string1 = Console.ReadLine();


            //bool containsOnlyDigits = true;

            //foreach (char c in string1)
            //{
            //    if (!char.IsDigit(c))
            //    {
            //        Console.WriteLine("The string contains non-digit characters.");
            //        containsOnlyDigits = false;
            //        break;
            //    }
            //}
            //if (containsOnlyDigits)
            //{
            //    Console.WriteLine("The string contains only digits.");
            //}

            //Console.ReadLine();

        }
    }
}
