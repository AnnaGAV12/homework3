// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число N ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++) 
{
    Console.WriteLine($"{i} x {i} = {i * i} ");
    Console.WriteLine();
}
