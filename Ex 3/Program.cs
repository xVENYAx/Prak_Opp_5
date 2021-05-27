using System;

namespace Ex_3
{
    class Program
    {
     /* Завдання 3. Знайти найдовше слово в реченні.
      Користувач повинен ввести строку.Необхідно зчитати значення
      строки.Розбити строку на масив строк (в якості роздільників
      використовувати пробіл, крапку та кому). Визначити найдовше слово –
      вивести його на екран та кількість символів в ньому.*/
        static void Main(string[] args)
        {
            Console.Write("Write your txt: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Longest word: {0}", str[index]);
            Console.ReadLine();
        }        
    }
}
