using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Arrays_Strings
{
    public class ArrayCalculations
    {
        //median -The median is the middle value of a sorted 
        public static void FindMedian(int[] array1)
        { 
            Array.Sort(array1);
            int length=array1.Length;

            if (length % 2 == 0)
            {
                double median = (array1[length / 2 - 1] + array1[length / 2]) / 2;
                Console.WriteLine("median : " + median);
            }
            else 
            {
                int median = array1[length / 2];
                Console.WriteLine("\nmedian : " + median);
            }
        
        }
        //mode- is the value that appears most frequently
        public static void FindMode(int[] array1) 
        {
            Dictionary<int,int> frequency = new Dictionary<int, int>();
            int mode = array1 [0];
            int maxCount = 0;

            foreach (int num in array1)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else 
                {
                    frequency[num] = 1;
                }

                if (frequency[num] > maxCount)
                {
                    maxCount = frequency[num];
                    mode = num;
                }
            }
            Console.WriteLine("mode: " + mode);
            
        }


        //find highest and second highest
        public static void HighestAndSecondHighest(int[] array)
        {
            // Sort the array 
            Array.Sort(array);
            int length = array.Length;

            
            Console.WriteLine("Highest value: " + array[length - 1]);

            //iterate from second last element to first element
            for (int i = length - 2; i >= 0; i--)
            {
                //return the first element which is not equal to the largest element
                if (array[i] != array[length - 1])
                {
                    Console.WriteLine("Second highest value: " + array[i]);
                    break;
                }
            }
        }
            //duplicate element

            public static void FindDuplicate(int[] array1)
            {
                Dictionary<int, int> frequency = new Dictionary<int, int>();

                // Count frequency of each number
                foreach (int num in array1)
                {
                    if (frequency.ContainsKey(num))
                    {
                        frequency[num]++;
                    }
                    else
                    {
                        frequency[num] = 1;
                }
            }
            Console.WriteLine("Duplicated Elements:");
            foreach (var key in frequency)
            {
                if (key.Value > 1)
                {
                    Console.WriteLine($"Element {key.Key}");
                }
            }


        }

    }
}
