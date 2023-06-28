// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
//  числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;
class Program
{
    static void Main(string[] args)
    {
        //Creat class 
        int[] numbers = new int[10];
        Random random = new Random();
        // Complite array randow numbers 
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }
        // Подсчитываем количество четных чисел в массиве
        int evenCount = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }
        // Вывдим результат
    Console.WriteLine("Количество четных чисел в массиве:" + evenCount);
    }
}