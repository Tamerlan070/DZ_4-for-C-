// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
int summa = 0;

while (count > 0)
{
int number = count % 10;
count = count / 10;
summa = summa + number;
}
Console.WriteLine("Cумма цифр в числе равна: " + summa);

