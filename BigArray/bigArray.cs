using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigArray
{


    class bigArray
    {

        static void Main(string[] args)
        {
            int n;
            List<int> arr = new List<int>();
            Random rd = new Random();
            Console.Write("So luong phan tu mang: ");
            n = int.Parse(Console.ReadLine());

            //Nhập mãng tự động
            for (int i = 0; i < n; i++)
            {
                arr.Add(rd.Next(-1000, 1000));
            }

            //Xuất mãng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            int max = 0, min = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                }
                else if(arr[i]<=min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"max = {max}, min = {min}");
        }
    }
}
