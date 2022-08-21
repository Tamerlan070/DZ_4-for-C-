// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите  число А : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  число B : ");
int numberB = Convert.ToInt32(Console.ReadLine());
int sum = numberA;

for (int i = 1; i < numberB; i++) 
{
    sum = sum *numberA;
};
Console.WriteLine($"Число А в степени В равно = {sum}");