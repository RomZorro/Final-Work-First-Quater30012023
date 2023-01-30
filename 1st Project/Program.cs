using System;
class Program
{ static void Main(string[] args)
    {
        // Ввод количества элементов массива с клавиатуры
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());
        // Ввод элементов массива с клавиатуры
        string[] arr = new string[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Введите строку {0}: ", i);
            arr[i] = Console.ReadLine();
        }
        // Вывод массивов длинна которых меньше или равна 3 символам
        Console.Write("\nМассивы длинна которых меньше или равна 3 символам: ");
        foreach (string s in arr)
        {
            if (s.Length <= 3)
                Console.Write("{0} ", s );
        }
        Console.WriteLine();
    }
}