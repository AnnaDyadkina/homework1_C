// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 2;
string result = "";
if (number == 1) {
  result = "Нет четных чисел";
}
else {
  while (count <= number) {
    if (count == 2) {
      result = result + count;
    }
    else {
        result = result + ", " + count;
    }
    count = count + 2;
  }
}
Console.WriteLine(result);
