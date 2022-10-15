// Задать массив из 12 элементов, заполненных числами из [0,9]???. Найти сумму положительных/отрицательных элементов массива


void ZapolMas(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);
        index++;
    }
}

void PechMas(int[] col)
{
    int dlinna = col.Length;
    int i = 0;
    while (i < dlinna)
    {
        Console.Write(col[i] + "   ");
        i++;
    }
}



int[] massiv = new int[12];

Console.WriteLine("Вывод массива: ");
ZapolMas(massiv);
PechMas(massiv);
Console.WriteLine();



int sumplus = 0;
int summinus = 0;
int count = 0;

while (count < massiv.Length)
{
    if (massiv[count] > 0)
    {
        sumplus = sumplus + massiv[count];
        count++;
    }
    else
    {
        summinus = summinus + massiv[count];
        count++;
    }
}
Console.WriteLine("Вывод суммы положительных чисел: " + sumplus);
Console.WriteLine("Вывод суммы отрицательных чисел: " + summinus);
