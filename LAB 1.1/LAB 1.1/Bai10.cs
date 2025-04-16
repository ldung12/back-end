using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int n;
        do
        {
            Console.Write("Nhập số : ");
        }
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 1);

        bool isPrime = true;
        if (n == 2)
        {
            isPrime = true;
        }
        else if (n % 2 == 0)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine($"{n} {(isPrime ? "là" : "không phải là")} số nguyên tố");
    }
}