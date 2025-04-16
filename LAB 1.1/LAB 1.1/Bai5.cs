//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        double NhapSo(string prompt)
//        {
//            double so;
//            Console.Write(prompt);
//            while (!double.TryParse(Console.ReadLine(), out so))
//                Console.Write("Lỗi! " + prompt);
//            return so;
//        }

//        double a = NhapSo("Nhập số thứ nhất: ");
//        double b = NhapSo("Nhập số thứ hai: ");

//        Console.WriteLine($"Tổng: {a} + {b} = {a + b}");
//        Console.WriteLine($"Tích: {a} × {b} = {a * b}");
//    }
//}