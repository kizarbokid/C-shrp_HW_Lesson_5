// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
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
        arr[i] = rand.Next(-100, 101);
        Console.Write($"_{arr[i]}_");
    }
    Console.WriteLine();
    return arr;
}
int n = input();
int[] arr = create_rand_arr(n);

int sum=0;
for (int i=0;i<n;i=i+2)
{sum=sum+arr[i];}

Console.WriteLine($"Сумма нечетных элементов массива = {sum};");