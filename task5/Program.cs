// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
if (num > 9 | num < 100)
{
    sum = num/10 + num%10;
}
if (num > 99 | num < 1000)
{
    sum = num/100 + num/10%10 + num%10;
}
if (num > 999 | num < 10000)
{
    sum = num/1000 + num/100%10 + num/10%10 + num%10;
}
else sum = num;
Console.WriteLine($"Сумма цифр числа = {sum} ");
