using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Buble sorting
            Console.WriteLine("Сортування бульбашкою: ");

            int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};           
            for (int i = 0; i < arrayInt.Length-1; i++)
            {
                for (int j = i+1; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] > arrayInt[j])
                    {
                        int tmp = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = tmp;
                    }
                }
            }
            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }


            //Parse sorting
            Console.WriteLine("\n Сортування вставкою: ");
            // int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};
            int min;
            int minI;            
            for (int i = 0; i < arrayInt.Length-1; i++)
            {
                min = arrayInt[i];
                minI = i;
                for (int j = i+1; j < arrayInt.Length; j++)
                {
                    if (min > arrayInt[j])
                    {
                        minI = j;
                        min = arrayInt[j];
                    }
                }
                arrayInt[minI] = arrayInt[i];
                arrayInt[i] = min;
            }

            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }

            // Array.Sort();
            Console.WriteLine("\n Сортування методом Array.Sort(): ");
            // int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};

            Array.Sort(arrayInt);
            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }
            
            //Сортування string
            string[] arrayStr = { "apple", "welcome", "gnome", "member", "spring", "book" };
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("\n Массив до сортування: ");
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Iндекс елемента 'gnome' у массивi: ");
            Console.WriteLine(Array.IndexOf(arrayStr, "welcome"));
            Console.WriteLine(Array.BinarySearch(arrayStr, "welcome"));

            Console.Write("\n Сортування string методом Array.Sort(): ");
            Array.Sort(arrayStr);
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Iндекс елемента 'gnome' у массивi пiсля сортування: ");
            Console.WriteLine(Array.IndexOf(arrayStr, "welcome"));
            Console.WriteLine(Array.BinarySearch(arrayStr, "welcome"));

            //Інверування string
            Console.Write("\n Iнвертування string методом Array.Reverse(): ");
            Array.Reverse(arrayStr);
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }
            //Array.Clear():
            Console.WriteLine("\n");
            Console.Write("Очищення значення елементу Array.Clear(): ");
            Array.Clear(arrayStr, 2, arrayStr.Length-2);
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }
            // Array.Copy(): 
            
            string[] arrayStr1 = new String[arrayStr.Length - 2];
            string[] arrayStr2 = new String[arrayStr.Length - 2];
            Array.Copy(arrayStr, arrayStr1, arrayStr.Length-2);
            
            Console.WriteLine("\n");
            Console.WriteLine("Array.Copy()");
            Console.Write("arrayStr1: ");
            foreach (string a in arrayStr1)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine("\n");
            Array.Copy(arrayStr, 1, arrayStr2, 0, arrayStr.Length - 2);
            Console.Write("arrayStr2: ");
            foreach (string a in arrayStr2)
            {
                Console.Write($"{a} ");
            }

            //Array.Resize():
            Console.WriteLine("\n");
            Array.Resize(ref arrayStr, arrayStr.Length - 2);
            arrayStr[arrayStr.Length - 1] = "New one";
            Console.WriteLine("Пiсля Array.Resize(): ");
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }

            Console.ReadKey();
        }        
    }
}
