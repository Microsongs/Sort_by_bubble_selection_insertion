using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sort
{
    class sort
    {
        public static void Bubble(List<int> arr)  //Bubble Sort
        {
            for(int i = 0; i < (arr.Count-1) ; i++)
            {
                for(int j = 0; j < (arr.Count-1) - i; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        swap(arr, j, j + 1);
                    }
                }
            }
        }
        public static void Insertion(List<int> arr)
        {
            int Min;
            for(int i = 0; i < arr.Count - 1; i++)
            {
                Min = i;
                for(int j=i+1; j<arr.Count; j++)
                {
                    if(arr[j] < arr[Min])
                    {
                        Min = j;
                    }
                }
                swap(arr, i, Min);
            }
        }
        public static void Selection(List<int> arr)
        {
            int j;
            for(int i=1; i<arr.Count; i++)
            {
                j = i;
                while((j > 0) && (arr[j-1] > arr[j]))
                {
                    swap(arr, j, j - 1);
                    j--;
                }
            }
        }

        public static void swap(List<int> arr, int a, int b)    //Swap
        {
            int temp;
            temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            int index;
            Console.Write("인덱스 크기 지정 : ");
            index = int.Parse(Console.ReadLine());
            // list.Capacity = index;

            // Bubble Sort
            Console.WriteLine("-------------------Bubbue---------------------");
            for(int i = 0; i < index; i++)
            {
                list.Add(random.Next() % 100 + 1);  //1~100
            }

            Sort.sort.Bubble(list);

            foreach(int print in list)
            {
                Console.WriteLine(print);
            }

            // Insertion Sort
            Console.WriteLine("-------------------Insertion---------------------");
            list.Clear();
            for (int i = 0; i < index; i++)
            {
                list.Add(random.Next() % 100 + 1);  //1~100
            }

            Sort.sort.Insertion(list);

            foreach (int print in list)
            {
                Console.WriteLine(print);
            }

            // Selection Sort
            Console.WriteLine("-------------------Selection---------------------");
            list.Clear();
            for (int i = 0; i < index; i++)
            {
                list.Add(random.Next() % 100 + 1);  //1~100
            }

            Sort.sort.Selection(list);

            foreach (int print in list)
            {
                Console.WriteLine(print);
            }
        }
    }
}
