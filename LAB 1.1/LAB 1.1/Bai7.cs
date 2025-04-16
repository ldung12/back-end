//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.InputEncoding = System.Text.Encoding.UTF8;

//        int year;

//        while (true)
//        {
//            Console.Write("Nhập năm (số nguyên dương): ");
//            if (int.TryParse(Console.ReadLine(), out year) && year > 0)
//            {
//                break;
//            }
//            Console.WriteLine("Năm không hợp lệ! Vui lòng nhập lại.");
//        }

//        bool isLeapYear = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);

//        Console.WriteLine($"{year} {(isLeapYear ? "là" : "không phải là")} năm nhuận");
//    }
//}