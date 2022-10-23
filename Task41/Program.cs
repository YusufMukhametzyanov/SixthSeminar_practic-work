/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

System.Console.WriteLine("Enter five numbers:");
int numberFirst = int.Parse(Console.ReadLine());
int numberSecond = int.Parse(Console.ReadLine());
int numberThird = int.Parse(Console.ReadLine());
int numberFourth = int.Parse(Console.ReadLine());
int numberFifth = int.Parse(Console.ReadLine());

int count = 0;

if (numberFirst > 0) count++;
if (numberSecond > 0) count++;
if (numberThird > 0) count++;
if (numberFourth > 0) count++;
if (numberFifth > 0) count++;

System.Console.WriteLine($"Вы ввели {count} чисел(а) больше 0");
