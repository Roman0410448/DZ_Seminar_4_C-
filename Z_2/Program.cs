﻿// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,100);
    Console.Write(randomArray[i] + ", ");
}


