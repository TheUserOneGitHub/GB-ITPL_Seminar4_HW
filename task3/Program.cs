// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

long[] array = new long[8];

long i = 0; 
while (i < 8)
{
    array[i] = new Random().Next(-100,100);
    Console.Write($"{array[i]} ");
    i++;
}