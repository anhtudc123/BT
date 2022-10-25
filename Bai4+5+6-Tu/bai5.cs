using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class bai5
    {
        public static void Main()
        {
            string[] Name = new string[9] { "CPU", "RAM", "HDD", "Main", "Keyboard", "Mouse", "VGA", "Monitor", "Case" };
            int[] Price = new int[9] { 750, 50, 70, 400, 30, 25, 60, 120, 120 };
            int[] Quality = new int[9] { 10, 2, 1, 3, 8, 50, 35, 28, 28 };
            int[] Categoryid = new int[9] { 1, 2, 2, 1, 4, 4, 3, 2, 5 };
            //bai 5
            Console.WriteLine("nhap id product: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac product co id cua ban la ");
            for (int i = 0; i < 9; i++)
            {
                if (id == Categoryid[i])
                {
                    Console.Write(" " + Name[i]);
                }
            }
            Console.ReadKey();
            
        }
    }
}
