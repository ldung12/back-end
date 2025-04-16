//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.InputEncoding = System.Text.Encoding.UTF8;

//        Console.Write("Nhập tên của bạn: ");
//        string ten = Console.ReadLine();

//        int tuoi;
//        while (true)
//        {
//            Console.Write("Nhập tuổi của bạn: ");

//            if (int.TryParse(Console.ReadLine(), out tuoi) && tuoi > 0)
//            {
//                break; 
//            }

//            Console.WriteLine("Lỗi!");
//        }

//        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
//    }
//}