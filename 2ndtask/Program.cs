// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("input number1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input number2");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input number3");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num2;

if (num1 > max) max = num1;
if (num3 > max) max = num3;

Console.WriteLine ("max"+ max);






