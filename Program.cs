﻿// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, 
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int [] array= new int [4];

// int count =0;

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(100,1000);
// Console.Write(array[i]+ " ");
// if (array[i] % 2==0)
// {
// count++;    
// }
// }
// Console.WriteLine("Четных равно " + count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array= new int [4];
// int count = 1;
// int sum = 0;

// for(int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-99,100);
//   Console.Write(array[i] + " ");
// }

// while(count < array.Length)
// {
//   sum = sum + array[count]; 
//   count += 2;
// }  
//   Console.WriteLine(sum);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным
//  элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] array = new double[4];

for(int i = 0; i < array.Length; i++)
{
  array[i] = Math.Round(new Random().Next(0,100) + new Random().NextDouble());
  Console.Write(array[i] + " ");
}

double max = array[0];
double min = array[0];

int k = 1;

while(k < array.Length)
{
  if(array[k] > max) max = array[k];
  if(array[k] < min) min = array[k];
  k++;
}
Console.WriteLine("Разница " + (max-min));