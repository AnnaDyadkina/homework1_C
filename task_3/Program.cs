﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int number_1 = int.Parse(Console.ReadLine());
string message;
if (number_1 % 2 == 0) {
  message = "Четное";
}
else {
  message = "Нечетное";
}
Console.WriteLine(message);
