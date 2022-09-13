// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. проверяет, является ли первое число квадратом второго.
// 3. вывод результата Да или Нет
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); // -2 147 483 648 до 2 147 483 648
int square = num2 * num2;
if (square == num1)
{
  Console.Write($"Число {num1}  является квадратом числа {num2}");
}
else {
Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
}


 
