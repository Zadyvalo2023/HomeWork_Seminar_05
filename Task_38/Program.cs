﻿// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
using System;
class Program{
    static void Main()
    {
        // Задаем массив вещественных чисел 
        double[] numbers = { 1.5, 3.2, 4.7, 2.1, 5.6 };
        // Инициализируйте переменные для максимального и минимального значения 
        double min = numbers[0];
        double max = numbers[0];
        // Найдите минимальное и максимальное значение в массиве
        for (int i = 1;i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        // Найдите разницу между максимальном и минимальном элементами
        double difference = max - min;
        //  Выводим результат на консоль 
        Console.WriteLine("Разница между максимальном и минимальном элементами: " + difference);
    }
}