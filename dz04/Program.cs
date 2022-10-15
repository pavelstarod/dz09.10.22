// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


void FillMas(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 150);
        index++;
    }
}

void PrintMas(int[] col)
{
    int dlinna = col.Length;
    int i = 0;
    while (i < dlinna)
    {
        Console.Write(col[i] + "    ");
        i++;
    }
}


int[] massiv = new int[123];

FillMas(massiv);
PrintMas(massiv);
Console.WriteLine();

int ind = 0;
int result = 0;
Console.WriteLine("Вывод количества элементов из отрезка [10,99]: ");
while (ind < massiv.Length)
{
    if (massiv[ind] > 10 && massiv[ind] < 99)
    {
        result++;
    }
    ind++;
}
Console.WriteLine(result);
