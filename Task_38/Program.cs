// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int input()
{
    Console.Write("Введите размерность массива: ");
    string len = Console.ReadLine();
    return int.Parse(len);
}
float[] create_rand_arr(int n)
{
    var rand = new Random();
    float[] arr = new float[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rand.NextSingle() * rand.Next(-100, 101);
        Console.Write($"_{arr[i]}_");
    }
    Console.WriteLine();
    return arr;
}
int n = input();
float[] arr = create_rand_arr(n);

float max = arr[0];
float min = arr[0];
for (int i = 0; i < n; i++)
{
    if (arr[i] > max)
    {
        max=arr[i];
    }
        if (arr[i] < min)
    {
        min=arr[i];
    }
}

Console.WriteLine($"Разность {max} и {min} = {max-min};");