using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class bai6
    {
        public static void Main()
        {
            string[] Name = new string[9] { "CPU", "RAM", "HDD", "Main", "Keyboard", "Mouse", "VGA", "Monitor", "Case" };
            int[] Price = new int[9] { 750, 50, 70, 400, 30, 25, 60, 120, 120 };
            int[] Quality = new int[9] { 10, 2, 1, 3, 8, 50, 35, 28, 28 };
            int[] Categoryid = new int[9] { 1, 2, 2, 1, 4, 4, 3, 2, 5 };

            Console.WriteLine("Nhap gia ca mong muon: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac product co gia trong tam cua ban la:");
            for (int i = 0; i < 9; i++)
            {
                if (Price[i] < price)
                {
                    Console.Write(" " + Name[i]);
                }
            }
            Console.ReadKey();
        }
    }
}