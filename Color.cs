﻿using System;

namespace ConsoleApp3
{
    internal class Color
    {
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}\n{1} Напишите свой любимый цвет на английском с маленькой буквы", username, userage);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        static int[] GetArrayFromConsole() 
        { 
            int[] result=new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива");
                result[i]=int.Parse(Console.ReadLine());    
            }
            return result;
        }

        static int[] GetSortArray(int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0+i;  j<array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static void Main(string[] args)
        {

            //var (name, age) = ("Евгения", 27);
           //Console.WriteLine("Мое имя: {0}", name);
           // Console.WriteLine("Мой возраст: {0}", age);
            //Console.Write("Введите имя: ");
           // name = Console.ReadLine();
            //Console.Write("Введите возрас с цифрами:");
            //age = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            //string[] favcolor=new string[3];
            
           /* for (int i = 0; i < favcolor.Length; i++)
            {
                favcolor[i]=ShowColor(name, age);
            }
            Console.WriteLine("Ваши любимые цвета");

            foreach (var item in favcolor)
            {
                Console.WriteLine(item);
            }*/

            int[] result=GetArrayFromConsole();
            result = GetSortArray(result);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]+" ");
            }
        }
    }
}
