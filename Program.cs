﻿/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

Console.Write("Введите числовое значение интересующего вас дня: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a>=1 && a <= 5)
{                                                           
Console.WriteLine($"введенная цифра является рабочим днем");
}
else if (a>=6 && a<=7)
Console.WriteLine($"введенная цифра является выходным днем");                                                       

else if (a<1 || a>7)  
Console.WriteLine($"Введенное число не входит в диапазон допустимых значений");

                            ИЛИ

*/

Console.Write("Введите числовое значение интересующего вас дня: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a==1)
{                                                           
Console.WriteLine($"Понедельник является рабочим днем");
}
else if (a==2)
Console.WriteLine($"Вторник является рабочим днем");
else if (a==3)
Console.WriteLine($"Среда является рабочим днем");
else if (a==4)
Console.WriteLine($"Четверг является рабочим днем");
else if (a==5)
Console.WriteLine($"Пятница является рабочим днем");
else if (a==6)
Console.WriteLine($"Суббота является выходным днем");
else if (a==7)
Console.WriteLine($"Воскресенье является выходным днем");
else if (a<1 || a>7)  
Console.WriteLine($"Введенное число не входит в диапазон допустимых значений");