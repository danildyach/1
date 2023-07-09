using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _1231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 25");
            zd25();
            Console.WriteLine("задание 27");
            zd27();
            Console.WriteLine("задание 29");
            zd29();
        }
        static void zd25()
        {
            //Задача 25: Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
            //3, 5-> 243(3⁵)
            //2, 4-> 16
            int number = 1;
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= B; i++)
            {
                number *= A;
                Console.WriteLine(number);

            }
        }

        static void zd27()
        {
            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //452-> 11
            //82-> 10
            //9012-> 12
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int resultat = number % 10;
            for (int i = 0; i <= number; i++)
            {

                number /= 10;
                result = number % 10;
                resultat += result;
                Console.WriteLine(result);

            }

            Console.WriteLine($"сумма = {resultat}");


        }
        static void zd29()
        {
            //Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
            //1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
            //6, 1, 33-> [6, 1, 33]

            //Или массив из 8 элементов вводится с консоли(каждый элемент вводит человек)
            Console.WriteLine("Введите n");
            int array = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[array];
            for (int i = 0; i < array; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("\nМассив:[ {0}, ] ", String.Join(", ", a));
        }
    }
}
