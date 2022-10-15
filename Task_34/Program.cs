// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int input()
{
    Console.Write("Введите размерность массива: ");
    string len = Console.ReadLine();
    return int.Parse(len);
}
int[] create_rand_arr(int n)
{
    var rand = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rand.Next(100, 1000);
        Console.Write($"-{arr[i]}-");
    }
    Console.WriteLine();
    return arr;
}
int n = input();
int[] arr = create_rand_arr(n);
int count = 0;//счетчик занулить
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)//если делится нацело на 2 значит прирастить счетчик
    { count++; }
}
Console.WriteLine($"Четных чисел в массиве: {count};");