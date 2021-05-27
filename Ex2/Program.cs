using System;
using System.Linq;

namespace Ex_2
{
    class Program
    {
        // Завдання 2. Ступінчастий масив.
        //Створити двовимірний ступінчатий масив з N строк, кожна строка
        //містить на 2 елементи більше ніж попередня, перша строка
        //містить 1 елемент.Значення елементів масиву впорядкувати за
        //зростання починаючи з 1. Вивести на екран масив та суму
        //максимальних елементів кожного виміру.


        // Метод для знаходження максимального значення
        static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; ++i)

                if (a[i] > max) { max = a[i]; }
            return max;
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int N = int.Parse(Console.ReadLine());
            int[][] array = new int[N][];
            array[0] = new int[1];

           // Створення ступінчатого масиву в якому кожен наступний масив має на 2 елементи більшен ніж попередній
            for (int i = 1; i < N; i++)
            {
                array[i] = new int[i*2+1];
               
            }
            // Заповнення масиву
            for (int i = 0; i < N; i++)
            {
                int len = array[i].Length;
                string s = "";

                for (int j = 0; j < len; j++)
                {

                    array[i][j] = j + 1;
                    s += array[i][j].ToString() + " ";

                }
                Console.WriteLine($"Mассив {i+1}: ");
                Console.WriteLine(s);
                Console.WriteLine("Максимальный елемент массиву: " + Max(array[i]));

            }

            int[] rez = new int[array.Length]; // оголошення нового масиву для того щоб знайти суму
            // Сума максимальних елементів
            for (int i = 0; i < array.Length; i++)
                rez[i] = Max(array[i]);
            int sum = rez.Sum();
            Console.WriteLine("Сумма максимальных елементов массива: " + sum);

            Console.ReadKey();
        }        
    }
}
