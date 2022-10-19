
/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*Console.WriteLine("Input a: ");

// вводим переменную a
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b: ");

// вводим переменную b
int b = Convert.ToInt32(Console.ReadLine());

// находим максимальное из двух
if (a > b)   
{ 
    //Console.WriteLine("Some text1");
    Console.WriteLine($"Max: {a}"); 
}
else  
{
    //Console.WriteLine("Some text2");
    Console.WriteLine($"Max: {b}");
}*/

//==============================================================================================================================
//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*Console.WriteLine("Введите a: ");

// вводим переменную a
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b: ");

// вводим переменную b
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите c: ");

// вводим переменную c
int c = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
// находим максимальное из двух
if (a > b)   
{ 
    max1 = a;
}
else  
{
    max1 = b;
}

// находим максимальное из max1 и c
if (max1 > c) 
{
    Console.WriteLine($"Max: {max1}");
}
else 
{
    Console.WriteLine($"Max: {c}");    
}*/

//==============================================================================================================================
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
/*Console.WriteLine("Введите a: ");
 
// вводим переменную a
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}*/

//==============================================================================================================================
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите N: ");
 
// вводим переменную a
int N = Convert.ToInt32(Console.ReadLine());

int counter = 2;
while (counter <= N) 
{
    Console.Write($"{counter}, ");
    counter += 2;
}


