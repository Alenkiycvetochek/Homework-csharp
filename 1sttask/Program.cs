//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее


Console.WriteLine("input number1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input number2:");
int num2 = Convert.ToInt32(Console.ReadLine());

int min = num1;
int max = num2;

if (num1>max)
{
    max = num1;
    min = num2;
}

Console.WriteLine ("max"+ max);
Console.WriteLine ("min"+ min);
