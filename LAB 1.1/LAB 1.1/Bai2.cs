//using System;

//internal class Bai2
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.InputEncoding = System.Text.Encoding.UTF8; 

//        double dai, rong;  

//        while (true)
//        {
//            Console.Write("Nhập chiều dài (>0): ");
//            if (double.TryParse(Console.ReadLine(), out dai) && dai > 0) break;
//            Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại!");
//        }

//while (true)
//{
//    Console.Write("Nhập chiều rộng (>0): ");
//    if (double.TryParse(Console.ReadLine(), out rong) && rong > 0) break;
//    Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại!");
//}

//double dienTich = dai * rong;  
//Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich:0.##}");
//    }
//}