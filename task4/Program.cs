// Возведите число А в натуральную степень B, используя цикл

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int result = a;
for (int i = 2; i <= b; i++) result = result * a;
Console.WriteLine($"Число {a} в степени {b} = {result}");