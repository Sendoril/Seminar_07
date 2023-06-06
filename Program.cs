//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
//m = 3, n = 4.
//
//0,5 7 -2 -0,2
//
//1 -3,3 8 -9,9
//
//8 7,8 -7,1 9
//
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//
//Например, задан массив:
//
//1 4 7 2
//
//5 9 2 3
//
//8 4 2 4
//
//17 -> такого числа в массиве нет
//
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System;
using System.Threading;
Console.WriteLine("Привет пользователь!");
Thread.Sleep(1000);
string word = "Выбери что ты хочешь сделать:\nЗадача №1: Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.\nЗадача №2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет\nЗадача №3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце\nВаш выбор? \n";

foreach (char letter in word)
{
    Console.Write(letter);
    Thread.Sleep(25);
}

int chose;
chose = Convert.ToInt32(Console.ReadLine());
switch (chose)
{
    case 1:

        Console.Write("Введите колличество строк: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите колличество столбцов: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] randomArray = new double[m, n];

        void mas(int m, int n)
        {
            int i, j;
            Random rand = new Random();
            for (i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n; j++)
                {
                    randomArray[i, j] = rand.Next(0, 100);
                    Console.Write($"{randomArray[i, j]} ");
                }

            }

        }

        mas(m, n);
        break;
    case 2:
        Console.Write("Введите количество строк: ");
        int m1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите колличество столбцов: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        double[,] randomArray1 = new double[m1, n1];
        Console.Write("Введите позицию X: ");
        int m2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите позицию Y: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        void mas1(int m1, int n1)
        {
            int i, j;
            Random rand = new Random();
            for (i = 0; i < m1; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n1; j++)
                {
                    randomArray1[i, j] = rand.Next(0, 100);
                    Console.Write($"{randomArray1[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        mas1(m1, n1);
        if (m2 < 1 || n2 < 1)
            Console.Write("Позиции строк не могут быть отрицательными");
        else if (m2 <= m1 + 1 && n2 <= n1 + 1)
            Console.Write($"Значение элемента равно {randomArray1[m2 - 1, n2 - 1]} ");
        else Console.Write("Такого элемента нет в массиве");
        break;
    case 3:
        Console.Write("Введите размерность m массива: ");
        int m3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размерность n массива: ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        int[,] randomArray2 = new int[m3, n3];

        void mas2(int m3, int n3)
        {
            int i, j;
            Random rand = new Random();
            for (i = 0; i < m3; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n3; j++)
                {
                    randomArray2[i, j] = rand.Next(1, 9);
                    Console.Write($"{randomArray2[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        void arif(int m3, int n3)
        {
            Console.Write("Среднее арифметическое каждого столбца: ");
            int i, j;
            Random rand = new Random();
            for (j = 0; j < n3; j++)
            {
                double sum = 0;
                for (i = 0; i < m3; i++)
                {
                    sum = sum + randomArray2[i, j];
                }
                Console.Write($"{sum / (i):F1}; ");
            }
        }
        mas2(m3, n3);
        arif(m3, n3);
        break;
    default:
        Console.WriteLine("Выберете варианты 1-3");
        break;
}