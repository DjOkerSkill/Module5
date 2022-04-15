using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static int[] GetArraryFromConsole() 
        { 
            int[] result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите число");
                result[i] = int.Parse(Console.ReadLine());  
            }

            Console.WriteLine("Массив после сортировки");

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 1+i; j < result.Length; j++)
                {
                    if (result[i] > result[j]) 
                    { 
                        int temp=result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }
        

        static void Main(string[] args)
        {
            
            int[] result=GetArraryFromConsole();

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            
        }
    }
}
