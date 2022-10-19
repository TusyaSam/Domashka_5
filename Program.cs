// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Clear();
// int[] array = new int[10];
// int n =0;

// for (int i=0; i<array.Length; i++)
//     {
//        array[i]=new Random().Next(100,1000);
//        Console.Write(array[i]+ " ");

//        if (array[i]%2==0) n++;
//     }
// Console.WriteLine();
// Console.Write($"количество четных чисел = {n}");   


 


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Clear();
// int[] array = new int[6];
// int sum =0;

// for (int i=0; i<array.Length; i++)
//     {
//        array[i]=new Random().Next(1,100);
//        Console.Write(array[i]+ " ");

//        if (i%2==0) sum=sum+array[i];
//     }
//  Console.WriteLine();
// Console.Write($"Сумма чисел с нечетной позицией (четным индексом) = {sum}"); 






// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Clear();
// double[] array = new double[6];
// double max=0;
// double min=1;

// for (int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().NextDouble();
//     Console.Write(array[i]+ " ");

//     if (array[i]>max) max=array[i];
//     else if (array[i]<min) min=array[i];
// }

// Console.WriteLine();
// Console.Write($"Разница между max {max} и min {min} = {max-min}"); 







// Задача 31: Задайте массив из 12 элементов, заполненный случайными
//  числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];
// int sumPlus=0;
// int sumMinus=0;

// for (int i=0;i<array.Length;i++)
// {
//     array[i] = new Random().Next (-9,10);
//     Console.Write(array[i]+ " ");
//     if (array[i]>0) sumPlus=sumPlus+array[i];
//     else sumMinus=sumMinus+array[i];
// }
// Console.WriteLine();
// Console.WriteLine($"сумма положительных = {sumPlus}");
// Console.WriteLine($"сумма отрицательных = {sumMinus}");






// Задача 32: Напишите программу замена элементов массива: положительные
//  элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.Clear();
// int[] array = new int[6];

// for (int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(-9,10);
//     Console.Write(array[i]+ "  ");
    

//     array[i]=0-array[i];
//     Console.Write($"{array[i]}");
//     Console.WriteLine(" ");
// }

// ИЛИ

// Console.Clear();
// int[] array = new int[6];

// for (int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(-9,10);
//     Console.Write(array[i]+ "  ");
// }
//  Console.WriteLine(" ");

//  for (int i=0; i<array.Length; i++)
//  {
//     array[i]=0-array[i];
//     Console.Write(array[i]+ "  ");
//  }
//  Console.WriteLine(" ");




// Задача 33: Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Clear();
// int[] array = new int[6];
// Console.Write ("Введите число от 1 до 10 N=");
// int N = Convert.ToInt32(Console.ReadLine());
// string p = "Нашего числа тут нет";

// for (int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(1,10);
//     Console.Write(array[i]+ "  ");
//     if (array[i]==N) p = "Ура, это число присутствует!";
// }
// Console.WriteLine(p);






// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
int[] array = new int[5];

for (int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(1,100);
    Console.Write(array[i]+ "  ");


    for (int count=0; array[i]>10 && array[i]<99; count=array[i]+count)
        {
            Console.WriteLine($"Количество чисел между 10 и 99 = {count}, не включая их");
        }
}




// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

