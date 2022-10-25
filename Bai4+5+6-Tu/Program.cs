using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using b4product;

namespace product2
{
    internal class Program
    {
        public static void Main()
        {
            //khai bao bien
            Product[] product = new Product[9];
            product[0] = new Product { Name = "CPU", Price = 750, Quality = 10, Categoryid = 1 };
            product[1] = new Product { Name = "Ram", Price = 50, Quality = 2, Categoryid = 2 };
            product[2] = new Product { Name = "HDD", Price = 70, Quality = 1, Categoryid = 2 };
            product[3] = new Product { Name = "Main", Price = 400, Quality = 3, Categoryid = 1 };
            product[4] = new Product { Name = "Keyboard", Price = 30, Quality = 8, Categoryid = 4 };
            product[5] = new Product { Name = "Mouse", Price = 25, Quality = 50, Categoryid = 4 };
            product[6] = new Product { Name = "VGA", Price = 60, Quality = 35, Categoryid = 3 };
            product[7] = new Product { Name = "Monitor", Price = 120, Quality = 28, Categoryid = 3 };
            product[8] = new Product { Name = "Case", Price = 120, Quality = 28, Categoryid = 5 };
            string[] Name = new string[9] { "CPU", "RAM", "HDD", "Main", "Keyboard", "Mouse", "VGA", "Monitor", "Case" };
            int[] Price = new int[9] { 750, 50, 70, 400, 30, 25, 60, 120, 120 };
            int[] Quality = new int[9] { 10, 2, 1, 3, 8, 50, 35, 28, 28 };
            int[] Categoryid = new int[9] { 1, 2, 2, 1, 4, 4, 3, 2, 5 };
            
            
        }
    }
}