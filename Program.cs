// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

if(num1 == num2)
System.Console.WriteLine("Числа равны");
else
{
    if (num1>num2)
    {  
        System.Console.WriteLine($"Большее число- {num1} Меньшее число -{num2}");
    }
    else
    {
        System.Console.WriteLine($"Большее число- {num2} Меньшее число - {num1}");
    }
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int Numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int Numb2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int Numb3 = Convert.ToInt32(Console.ReadLine());

if (Numb1 > Numb2)
{
    if (Numb1 > Numb3)
    {
        Console.WriteLine("Максимальное число: " + Numb1);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + Numb3);
    }
}

else if (Numb2 > Numb3)
{
    Console.WriteLine("Максимальное число: " + Numb2);
}
else
{
    Console.WriteLine("Максимальное число: " + Numb3);
}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0) 
Console.WriteLine("Четное");
else 
Console.WriteLine("Нечетное");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + N);
while (i <= N)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
 Console.WriteLine("Нет чётных чисел");
}