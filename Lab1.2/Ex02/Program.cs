//vi du
//using System;
//namespace LAB2
//{
//    class Program
//    {
//        public static void NhapMang(int[] a, int n)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"a[{i}]: ");
//                a[i] = int.Parse(Console.ReadLine());
//            }
//        }
//        public static int TinhTong(int[] a, int n)
//        {
//            int tong = 0;
//            for (int i = 0; i < n; i++)
//            {
//                tong += a[i];
//            }
//            return tong;
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            //Khai báo biến n
//            int n;
//            //Nhập giá trị cho biến n
//            Console.Write("Nhập n: ");
//            n = int.Parse(Console.ReadLine());
//            //Khai báo và khởi tạo mảng số nguyên có n phần tử
//            int[] a = new int[n];
//            //Gọi hàm nhập mảng
//            NhapMang(a, n);
//            //Gọi hàm Tính Tổng các phần tử trong mảng và hiển thị kết quả ra màn hình
//            Console.WriteLine($"Tổng = {TinhTong(a, n)}");
//        }
//    }
//}

//----------------------------------------------------------------------------------------------------------------


/*bai 1*/
//using System;
//using System;

//class Program
//{
//    public static void Main()
//    {
//        Console.Write("Nhap so phan tu cua mang: ");
//        int number = int.Parse(Console.ReadLine());

//        int[] a = new int[number];

//        for (int i = 0; i < number; i++)
//        {
//            Console.Write($"a[{i}]: ");
//            a[i] = int.Parse(Console.ReadLine());
//        }

//        int tong = TinhTongSoChan(a);

//        Console.WriteLine($"Tong cac so chan la : {tong}");
//    }
//    static int TinhTongSoChan(int[] a)
//    {
//        int tong = 0;
//        for (int i = 0; i < a.Length; i++)
//        {
//            if (a[i] % 2 == 0)
//                tong += a[i];
//        }
//        return tong;
//    }
//}



//-------------------------------------------------------------------------------------------------------

/*bai 2 */

//using System;

//namespace Ex02
//{
//    internal class Check
//    {
//        public static bool LaSoNguyenTo(int number)
//        {
//            if (number < 2)
//                return false;

//            for (int i = 2; i <= Math.Sqrt(number); i++)
//            {
//                if (number % i == 0)
//                    return false;
//            }

//            return true;
//        }
//        public static void Main(string[] args)
//        {
//            Console.Write("Nhap so luong ptu trong mang: ");
//            int n = int.Parse(Console.ReadLine());

//            int[] arr = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Nhap phan tu thu n  {i}: ");
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("\nCac phan tu la cac so nguyen to trong bang :");
//            for (int i = 0; i < n; i++)
//            {
//                if (LaSoNguyenTo(arr[i]))
//                {
//                    Console.WriteLine($"Chi so : {i}, Gia tri : {arr[i]}");
//                }
//            }

//            Console.ReadLine();
//        }
//    }
//}

//-----------------------------------------------------------------------------------------------

/*bai 3 */
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap so phan tu cua mang:");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"arr[{i}]: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        var (soAm, soDuong) = DemSoAmVaDuong(arr);
//        Console.WriteLine($"\nSo luong ptu am : {soAm}");
//        Console.WriteLine($"So luong ptu duong : {soDuong}");
//    }

//    static (int, int) DemSoAmVaDuong(int[] arr)
//    {
//        int soAm = 0;
//        int soDuong = 0;

//        foreach (int x in arr)
//        {
//            if (x < 0)
//                soAm++;
//            else if (x > 0)
//                soDuong++;
//        }

//        return (soAm, soDuong);
//    }
//}

//----------------------------------------------------------------------------------------------------

/*bai 4 */
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap so ptu : ");
//        int n = int.Parse(Console.ReadLine());

//        if (n < 2)
//        {
//            Console.WriteLine("Can 2 ptu!!.");
//            return;
//        }

//        int[] arr = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"arr[{i}]: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        int max2 = TimSoLonThuHai(arr);

//        if (max2 == int.MinValue)
//        {
//            Console.WriteLine("K hop le!!.");
//        }
//        else
//        {
//            Console.WriteLine($"So lon thu hai la: {max2}");
//        }
//    }

//    // Hàm tối ưu: duyệt 1 lần duy nhất
//    static int TimSoLonThuHai(int[] arr)
//    {
//        int max1 = int.MinValue;
//        int max2 = int.MinValue;

//        foreach (int x in arr)
//        {
//            if (x > max1)
//            {
//                max2 = max1;
//                max1 = x;
//            }
//            else if (x > max2 && x < max1)
//            {
//                max2 = x;
//            }
//        }

//        return max2;
//    }
//}
//----------------------------------------------------------------------------------------
/*bai 5 */
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap so a: ");
//        int a = int.Parse(Console.ReadLine());

//        Console.Write("Nhap so b: ");
//        int b = int.Parse(Console.ReadLine());

//        Console.WriteLine($"\nTrc khi hoan vi : a = {a}, b = {b}");

//        HoanVi(ref a, ref b);

//        Console.WriteLine($"Sau khi hoan vi : a = {a}, b = {b}");
//    }

//    // Hàm hoán vị dùng từ khóa ref
//    static void HoanVi(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }
//}
//-------------------------------------------------------------------------------------------------
/* bai 6 */
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập số phần tử của mảng: ");
//        int n = int.Parse(Console.ReadLine());
//        double[] arr = new double[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"arr[{i}]: ");
//            arr[i] = double.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("\nMảng trước khi sắp xếp:");
//        HienThiMang(arr);

//        // Sắp xếp mảng theo chiều tăng dần
//        Array.Sort(arr);

//        Console.WriteLine("\nMảng sau khi sắp xếp:");
//        HienThiMang(arr);
//    }

//    // Hàm hiển thị mảng
//    static void HienThiMang(double[] arr)
//    {
//        foreach (double x in arr)
//        {
//            Console.Write(x + " ");
//        }
//        Console.WriteLine();
//    }
//}
//-----------------------------------------------------------------------------------------
