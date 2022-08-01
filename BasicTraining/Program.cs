using System;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    public class Program
    {
       static void Main(string[] args)
        {
            Console.Write("So thu 1: ");
            int num1 = int.Parse(Console.ReadLine()); 

            Console.Write("So thu 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Thuc hien phep tinh: ");
            string toantu = Console.ReadLine();

            if (toantu == "+")
            {
                Phepcong(num1, num2);
            }
            else if (toantu == "-")
            {
                Pheptru(num1, num2);
            }
            else if (toantu == "*")
            {
                Phepnhan(num1, num2);
            }

            else if (toantu == "/")
            {
                Phepchia(num1, num2);
            }

        }
       static void Phepcong(int num1, int num2)
       {
           Console.WriteLine("Tong cua 2 so la:" + (num1 + num2));
           
        }
       static void Pheptru(int num1, int num2)
       { 
           Console.WriteLine("Hieu của 2 so la:" + (num1 - num2));
          
       }
        static void Phepnhan(int num1, int num2)
       {
         Console.WriteLine("Tich của 2 so la:" + (num1 * num2));
            
        }
        static void Phepchia(int num1, int num2)
       {
            if ( num2 != 0)
            {
                Console.WriteLine("Thuong cua 2 so la:" + (num1 / num2));
            }
            else if (num2 == 0)

            {
                Console.WriteLine("Khong the chia cho 0");
            }
       }
    }
}


