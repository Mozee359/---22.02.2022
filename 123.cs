using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // рандомайзер массива
            Console.WriteLine("Введите число n"); // выводит Введите число n
            var n = int.Parse(Console.ReadLine()); // вводится длинна массива
            int[] arr = new int[n];  // создается длинна массива
            Console.WriteLine("Получился массив:\n"); // выводит Получился массив: и сам массив
            for (int i = 0; i < n; i++) // цикл for до длинны массива
            {
                arr[i] = random.Next(-10, 20); // рандомайз массива
                Console.Write(arr[i] + " "); // вывод массива
            } // создается рандомный массив от -10 до 20

            for (int i = 0; i < n; i++) // цикл for до длинны массива
            {
                if (arr[i] % 2 == 0) // если i делится на 2, то оно чётное
                {
                    i++; // i++ потому что у массива счет начинается с 0 и при выводе 1 позиция выводилась бы нулём
                    Console.WriteLine("\nПервый четный элемент массива находится на позиции: " + i); // выводит Первый четный элемент массива находится на позиции: и ответ
                    return; // return для того, чтобы выводился ТОЛЬКО первый четный элемент массива
                }

            }

            Console.WriteLine("\nЧетных элементов нет"); // если четных элементов нету выводит Четных элементов нет
            Console.ReadLine();
        }
    }
}