using System;
using System.Linq;

namespace Encrease_massive_s_values
{
    class Program
    {
        static void ResizeUP(ref int[] MyArray, ref int elements, ref int change, ref bool flag)
        {
            int[] Arr = new int[change];
            Random rand = new();
            foreach (int i in Arr)
            {
                Arr[i] = rand.Next(1, 10);
            }
            if (flag == false)
            {
                int[] newArr = Arr.Concat(MyArray).ToArray();
                foreach (int i in newArr)
                {
                    Console.Write(i + " ");
                }
            }
            else if (flag)
            {
                int[] newArr = MyArray.Concat(Arr).ToArray();
                foreach (int i in newArr)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void ResizeDOWN(ref int[] MyArray, ref int elements, ref int change, ref bool flag)
        {
            if (flag == true)
            {
                int[] newArr = MyArray[0..^change];
                foreach (int i in newArr)
                {
                    Console.Write(i + " ");
                }
            }
            else if (flag == false)
            {
                int[] newArr = MyArray[change..];
                foreach (int i in newArr)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void Change_Ind(ref int[] MyArray, ref int elements, ref uint index)
        {
            Random rand = new();
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (i == index)
                {
                    MyArray[i] = rand.Next(1, 10);
                }
                Console.Write(MyArray[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter lenght of massive : ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 10);
                Console.Write(arr[i] + " ");
            }
            Console.Write("\nTo increase enter - up.\nTo reduce enter - down.\nTo change element under the index enter - change : ");
            Console.WriteLine();
            bool flag = false;
            string s = Console.ReadLine();
            switch (s)
            {
                case "up":
                    Console.Write("\nEnter value elements for change : ");
                    int change = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nTo change from begin enter - begin.\nTo change from end enter - end ");
                    string s1 = Console.ReadLine();
                    switch (s1)
                    {
                        case "begin":
                            flag = false;
                            ResizeUP(ref arr, ref n, ref change, ref flag);
                            break;
                        case "end":
                            flag = true;
                            ResizeUP(ref arr, ref n, ref change, ref flag);
                            break;
                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                    break;
                case "down":
                    Console.Write("\nEnter value elements for change : ");
                    int changedown = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nTo delete elements from begin enter - begin.\nTo delete elements from end enter - end ");
                    string s2 = Console.ReadLine();
                    switch (s2)
                    {
                        case "begin":
                            flag = false;
                            ResizeDOWN(ref arr, ref n, ref changedown, ref flag);
                            break;
                        case "end":
                            flag = true;
                            ResizeDOWN(ref arr, ref n, ref changedown, ref flag);
                            break;
                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                    break;
                case "change":
                    Console.WriteLine("Enter the number of index : ");
                    uint index = uint.Parse(Console.ReadLine());
                    Change_Ind(ref arr, ref n, ref index);
                    break;
                default:
                    Console.WriteLine("Wrong!!!");
                    break;
            }
        }
    }
}
