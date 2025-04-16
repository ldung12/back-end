//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        int number;
//        Console.Write("Nhập số: "); 
//        while (!int.TryParse(Console.ReadLine(), out number))
//        {
//            Console.Write("Lỗi! Vui lòng nhập số nguyên: ");
//        }

//        Console.WriteLine($"{number} là số {(number % 2 == 0 ? "chẵn" : "lẻ")}");
//    }
//}