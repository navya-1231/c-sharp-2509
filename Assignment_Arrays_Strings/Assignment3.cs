using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Arrays_Strings
{
    public class SearchAlgorithms
    {
        //linear search
        public static void LinearSearch(int[] array1, int target)
        {
            Console.WriteLine("using linear search");
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == target)
                {
                    
                    Console.WriteLine("Index of target: " + i);
                }
            }
            
        }

        //binary search
        public static void BinarySearch(int[] array,int target)
        {
            Console.WriteLine("using binary search");
            int low = 0;
            int high = array.Length - 1;

            while (low <= high) 
            {
                int mid = (low + high) / 2;
                if (array[mid] == target)
                {
                    Console.WriteLine("Index of target: " + mid);
                    break;
                }
                else if (array[mid] < target)
                {
                    low = mid + 1;// Search in the right half
                }
                else 
                {
                    high = mid - 1; // Search in the left half
                }
            }
            

        }
    }

    
}
