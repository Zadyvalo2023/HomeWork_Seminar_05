// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[10]; // Создаем массив Create array
        Random random = new Random ();// Jenerate random numbers 
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 101);// Генерируем случайоное число с одного до сотни
        }
    
        // Находим сумму элементов на нечетных points 
        int sum = 0;
        for (int i = 1; i < arr.Length; i +=2)
        {
            sum += arr[i];
        }
        Console.WriteLine("Сумма элументов на нечетных позициях: " + sum);

    }
}
