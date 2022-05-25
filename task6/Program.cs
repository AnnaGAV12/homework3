// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0) 
{
    Console.WriteLine($"Куб числа {num} равен {num * num * num}");
}
else 
{
    Console.WriteLine($"Число {num} не заканчивается на четную цифру");
}