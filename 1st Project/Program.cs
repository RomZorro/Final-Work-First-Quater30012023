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
    }
}