//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.InputEncoding = System.Text.Encoding.UTF8;

//        double doC;

//        while (true)
//        {
//            Console.Write("Nhập nhiệt độ (°C): ");
//            if (double.TryParse(Console.ReadLine(), out doC))
//            {
//                break;
//            }
//            Console.WriteLine("Lỗi: Phải nhập số!");
//        }

//        double doF = (doC * 9 / 5) + 32;
//        Console.WriteLine($"{doC}°C = {doF:0.##}°F"); 
//    }
//}