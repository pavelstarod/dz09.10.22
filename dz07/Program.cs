// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


void FillMas(double[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 15);
        index++;
    }
}

void PrintMas(double[] col)
{
    int dlinna = col.Length;
    int i = 0;
    while (i < dlinna)
    {
        Console.Write(col[i] + "    ");
        i++;
    }
}

double[] massiv = new double[12];

FillMas(massiv);
PrintMas(massiv);
Console.WriteLine();

int ind = 0;
double min = massiv[0];
double max = massiv[0];

while (ind < massiv.Length)
{
    if (min > massiv[ind]) min = massiv[ind];
    if (max < massiv[ind]) max = massiv[ind];
    ind++;
}
Console.WriteLine("min число: " + min);
Console.WriteLine("max число: " + max);
Console.WriteLine("Разница: " + (max - min));





