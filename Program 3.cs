using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static bool BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return true;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }

        static List<int> FindCommonElements(int[] arr1, int[] arr2)
        {
            List<int> commonElements = new List<int>();

            foreach (int element in arr1)
            {
                if (BinarySearch(arr2, element))
                    commonElements.Add(element);
            }

            return commonElements;
        }

        static void Main()
        {
            int[] array1 = { 2, 4, 8, 11, 13, 14 };
            int[] array2 = { 2, 4, 8, 7, 11, 13 };

            List<int> common = FindCommonElements(array1, array2);

            foreach (int num in common)
            {
                Console.Write(num + " ");
            }
        }
    }
}
