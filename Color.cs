using System;

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

        static int[] GetArrayFromConsole(int num) 
        { 
            int[] result=new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива");
                result[i]=int.Parse(Console.ReadLine());    
            }
            return result;
        }

        static void SortArray( int[] array, out int[] sortedesc,  out int[] sortedasc) 
        {
            sortedesc = SortArrayDesc(array);
            Console.WriteLine();
            sortedasc = SortArrayAsc(array);            
        }
        
        static int[] SortArrayAsc (int[] array)
        {
            int[] temparray=new int[array.Length];

            for (int i = 0; i < temparray.Length; i++)
            {
                temparray[i] = array[i];
            }
            for (int i = 0; i < temparray.Length; i++)
            {
                for (int j = 1 + i; j < temparray.Length; j++)
                {
                    if (temparray[i] > temparray[j])
                    {
                        int temp = temparray[i];
                        temparray[i] = temparray[j];
                        temparray[j] = temp;
                    }

                }
            }
            foreach (var item in temparray)
            {
                Console.Write(item + " ");
            }
            return temparray;
        }

        static int[] SortArrayDesc(int[] array)
        {
            int[] temparray = new int[array.Length];

            for (int i = 0; i < temparray.Length; i++)
            {
                temparray[i] = array[i];
            }
            for (int i = 0; i < temparray.Length; i++)
            {
                for (int j = 1 + i; j < temparray.Length; j++)
                {
                    if (temparray[i] < temparray[j])
                    {
                        int temp = temparray[i];
                        temparray[i] = temparray[j];
                        temparray[j] = temp;
                    }
                }

            }
            foreach (var item in temparray)
            {
                Console.Write(item + " ");
            }
            return temparray;
        }

        /*static void ShowArray(int[] array, bool issort = false) 
        {
            var temp = array;
            
            if (issort == true) 
            {
                 temp=SortArray(array);
            }
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }          
        }*/

        static void GetName(ref string name) 
        { 
            Console.WriteLine("Введите свое имя");
            name = Console.ReadLine();
        }

        public static void Main( string[] args)
        {
           int[] array = GetArrayFromConsole(3);
           int[] sortedesc; 
           int[] sortedasc;
           SortArray(array, out sortedesc, out sortedasc);
        }
    }
}
