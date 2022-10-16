// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.


void FillMas(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintMas(int[] col)
{
    int dlinna = col.Length;
    int i = 0;
    while (i < dlinna)
    {
        Console.Write(col[i] + "   ");
        i++;
    }
}

int[] massiv = new int[15];

FillMas(massiv);
PrintMas(massiv);
Console.WriteLine();

int ind = 0;
int result = 0;
Console.WriteLine("Вывод произведения пар чисел: ");
while (ind < massiv.Length / 2)
{
    Console.WriteLine(massiv[ind] * massiv[massiv.Length - 1 - ind]);
    ind++;
}

