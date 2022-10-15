//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2); //не пойму почему тут надо ставить ДО 2х??? чтобы массив выходил 0 и 1, последнее число не включительно всегда или где то ошибка?
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write(col[i]);
        i++;
    }
}

int[] array = new int[8];

Console.Write("Вывод массива: ");
FillArray(array);
PrintArray(array);

