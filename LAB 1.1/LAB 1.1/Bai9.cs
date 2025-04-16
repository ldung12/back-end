//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        int n;
//        do
//        {
//            Console.Write("Nhập số nguyên dương n (0 ≤ n ≤ 20): ");
//        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 20);

//        long giaiThua = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            giaiThua *= i;
//        }

//        Console.WriteLine($"{n}! = {giaiThua}");
//    }
//}