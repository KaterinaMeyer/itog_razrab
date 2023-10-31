using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] array = Console.ReadLine().Split();

        string[] newArray = Array.FindAll(array, str => str.Length <= 3);

        Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}