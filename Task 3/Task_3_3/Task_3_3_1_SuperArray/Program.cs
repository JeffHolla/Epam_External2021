﻿using System;
using System.Text;
using System.Threading.Tasks;

/* Задание
 * Расширьте массивы чисел методом, производящим действия с каждым конкретным элементом.
 * Действие должно передаваться в метод с помощью делегата.
 * 
 * Кроме указанного функционала выше, добавьте методы расширения для поиска:
 * - суммы всех элементов;
 * - среднего значения в массиве;
 * - самого часто повторяемого элемента;
 * На данном этапе LINQ использовать разрешается.
 * 
 * Консольный интерфейс-демонстрация для данного задания не обязателен, но постарайтесь
 * сделать интерфейсы ваших сущностей максимально понятными и готовыми к тестам.
 */

namespace Task_3_3_1_SuperArray
{
    class Program
    {
        static void Main(string[] args)
        {
            LetsSee lets = new LetsSee();
            lets.StartShow();


            Console.ReadKey();
        }
    }
}
