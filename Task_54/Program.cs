// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

using System;
using static System.Console;
Clear ();
WriteLine ($"Введите размер массива m*n и диапазон случайных значений: ");
int m = InputNumbers ("Введите m:");
int n = InputNumbers ("Введите n:");
int range = InputNumbers ("Введите диапазон: от 1 до ");

int[,] array = new int [m, n];
CreatArray (array);
WriteArray (array);

WriteLine ($"Отсортированный массив: ");
OrderArrayLines (array);
WriteArray (array);

void OrderArrayLines (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k =0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array [i, k + 1])
                {
                    int temp = array [i, k + 1];
                    array [i, k + 1] = array [i, k];
                    array [i, k] = temp;
                }
            }
        }
    }
}

int InputNumbers (string input)
{
    Write (input);
    int output = Convert.ToInt32(ReadLine());
    return output;
}

void CreatArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write (array[i, j] + " ");
        }
        WriteLine ();
    }
}