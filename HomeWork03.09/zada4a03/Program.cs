﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введи число,обозначающее день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void Number (int dayNumber) {

if (dayNumber == 6 || dayNumber ==7) {

Console.WriteLine("(Выходной день)");
}
else

    Console.WriteLine("(День не выходной)");
}
Number (dayNumber);

