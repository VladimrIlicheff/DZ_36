/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите число - размер массива");
int num = int.Parse(Console.ReadLine()!);
int[] RandomArray()
{
    int[] array = new int[num];
    Random rnd = new Random();

    for (int i = 0; i < num; i++)
        array[i] = rnd.Next(1,50);

    return array;
}
//создаем массив из случайных  чисел  

void PrintArray(int[] array)
{

    for (int i = 0; i < num; i++)
        Console.Write($"{array[i]} ");
}
// напечатать массив

int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < num; i++)
        if (array[i] % 2 != 0)
            sum=sum+array[i];
    return sum;
}
//считаем сумму нечётных чисел

int[] array = RandomArray();
PrintArray(array);
Console.WriteLine("");
int sum = SumOdd(array);
Console.WriteLine($"сумма нечетных чисел в массиве --->>> {sum}");


