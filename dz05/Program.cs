// Найти сумму чисел одномерного массива стоящих на нечетной позиции


void FillMas(int[]collection)
{
    int lenght=collection.Length;
    int index=0;
    while(index<lenght)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}

void PrintMas(int[]col)
{
    int dlinna=col.Length;
    int i=0;
    while(i<dlinna)
    {
        Console.Write(col[i] + "  ");
        i++;
    }
}

int[]massiv=new int[10];

FillMas(massiv);
PrintMas(massiv);
Console.WriteLine();

int ind=0;
int result=0;
while(ind<massiv.Length)
{
    if(massiv[ind]%2==1)
    {
        result=result+massiv[ind];
    }
    ind++;
}
Console.WriteLine("Вывод суммы чисел одномерного массива стоящих на нечетной позиции: " + result);
