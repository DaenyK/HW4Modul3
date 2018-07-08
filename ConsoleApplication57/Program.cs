using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            int nz;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("which task?(0 - exit)");
                nz = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (nz)
                {
                    case 0:
                        {
                        }
                        break;
                    case 1:
                        {
                            task1();
                        }
                        break; ;

                    case 2:
                        {
                            task2();
                        }
                        break;
                    case 3:
                        {
                            task3();
                        }
                        break;

                    case 4:
                        {
                            task4();
                        }
                        break;

                    case 5:
                        {
                            task5();
                        }
                        break;

                    case 6:
                        {
                            task6();
                        }
                        break;

                    case 7:
                        {
                            task7();
                        }
                        break;


                }
                Console.WriteLine();
            } while (nz > 0);
        }

        static void task1()
        {
            Console.WriteLine("Составить символьную строку из N звездочек: ");
            Console.Write("введите кол-во зведочек: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                Console.Write("*");
            Console.WriteLine();
        }

        static void task2()
        {
            Console.Write("Есть строка (любая), нужно удалить из этой строки знаки / и \\: ");
            string str = "привет\\ как дела, \\пока/";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '/' || str[i] == '\\')
                {
                    // str[i] = str[i + 1];
                    //почему здесь говорит, что только для чтения доступен str? 
                    //как тогда получить доступ для изменения
                }
            }
        }

        static void task3()
        {
            //•	Даны целые положительные числа A и B (A < B).Вывести все целые числа от A до B включительно;
            //каждое число должно выводиться на новой строке; при этом каждое число должно выводиться 
            //количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна 
            //сформировать в консоли следующий вывод: 
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7
            Console.Write("введите цифру A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("введите цифру B(чтобы она была больше A): ");
            int b = Int32.Parse(Console.ReadLine());
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 0; j < i; j++)
                        Console.Write(i + " ");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("а равно b, либо больше b");
        }

        static void task4()
        {
            Console.WriteLine("Написать программу, подсчитывающую количество цифр в заданной строке.");
            string str = "сегодня 1 января, 2018 года";
            Console.WriteLine(str);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57)
                    count++;
            }
            Console.WriteLine("цифр: {0}", count);

        }

        static void task5()
        {
            Console.WriteLine("Дан текст. Определить, есть ли в тексте слово one.");
            string str = "yes sir, i'm one of a kind";
            Console.WriteLine(str);
            if (!str.Contains("one"))
                Console.WriteLine("такого слова нет");
            else
                Console.WriteLine("такое слово есть");
        }

        static void task6()
        {
            Console.WriteLine("Дана строка, посчитать количество вхождений буквы P");
            string str = "сегодня 1 января, 2018 года. Радости всем!";
            Console.WriteLine(str);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'р' || str[i] == 'Р')
                    count++;
            }
            Console.WriteLine("кол-во букв р: {0}", count);
        }

        static void task7()
        {
            //Дана строка символов, состоящая из цифр от 0 до 9 и пробелов. 
            //Группы цифр, разделенные пробелами(одним или несколькими) и не содержащие 
            //пробелов внутри себя, будем называть словами. Рассматривая эти слова как числа,
            //определить и напечатать сумму чисел, оканчивающихся на цифры 3 или 4.   
            string str = "123 44 75 24 13 57 84";
            Console.WriteLine(str);
            int count = 0, countPos = 0;
            int[] pos = new int[5];

            int totalSum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                    if (str[i - 1] == '3' || str[i - 1] == '4')
                    {
                        pos[countPos] = count - 1;
                        countPos++;
                    }

                }
                else if (i == (str.Length) - 1)
                {
                    if (str[i] == '3' || str[i] == '4')
                    {
                        pos[countPos] = count;
                    }
                }
            }
            string[] strAr = str.Split(' ');

            int[] arr = new int[count + 1];
            countPos = 0;
            for (int i = 0; i < strAr.Length; i++)
            {
                arr[i] = Convert.ToInt32(strAr[i]);
                Console.WriteLine(arr[i]);
                if (i == pos[countPos])
                {
                    totalSum += arr[i];
                    countPos++;
                }
            }
            Console.WriteLine("сумма чисел, оканчивающихся на 3 или 4: {0}", totalSum);
        }


    }
}
