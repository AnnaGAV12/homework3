// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
//Первый вариант через заданный массив

//int[] arr = { 1, 0, 0, 1, 1, 0, 1, 0 };
//void PrintArray(int[] array)
//{
//    int count = array.Length;
//    for (int i = 0; i < count; i++)
//    {
//        Console.Write($"{array[i]} ");
//    }
//    Console.WriteLine();
//}
//PrintArray(arr);

//Второй вариант через рандом

int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++) 
{
    arr[i] = new Random().Next(0,2);
    Console.Write($"{arr[i]}");
}