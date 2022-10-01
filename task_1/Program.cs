// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_2 = int.Parse(Console.ReadLine());
string message;
if (number_1 == number_2) {
  message = "Числа равны";
}
else if (number_1 > number_2) {
  message = "Максимальное число " + number_1;
}
else {
  message = "Максимальное число " + number_2;
};
  Console.WriteLine(message);
