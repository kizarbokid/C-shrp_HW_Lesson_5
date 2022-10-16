// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. 
//Обновите список только при первом вхождении числа 20.
Console.Clear();
int input()
{
    Console.Write("Введите размерность массива (от 5 элементов и более): ");
    string len = Console.ReadLine();
    if (int.Parse(len) < 5) len = "5";
    return int.Parse(len);
}
int[] create_rand_arr(int n)
{
    var rand = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rand.Next(-100, 101);
    }
    return arr;
}
int n = input();
int[] arr = create_rand_arr(n);

arr[2] = 20;
arr[4] = 20;
for (int i = 0; i < n; i++)
{
    Console.Write($"_{arr[i]}_");
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
if (arr[i]==20)
{
    arr[i]=200;
    break;
}
}
for (int i = 0; i < n; i++)
{
    Console.Write($"_{arr[i]}_");
}
Console.WriteLine();