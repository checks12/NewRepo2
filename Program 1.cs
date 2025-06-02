using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());


            numbers.Add(number);


            Console.WriteLine($"Вы ввели число: {numbers[0]}");
        }
    }
}
