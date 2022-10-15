// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


void FillMas(int[]collection)
{
    int length=collection.Length;
    int index=0;
    while(index< length)
    {
        collection[index]=new Random().Next(100,1000);
        index++;
    }
}

void PrintMas(int[]col)
{
    int dlinna=col.Length;
    int i=0;
    while(i<dlinna)
    {
        Console.WriteLine(col[i]);
        i++;
    }
}

int[] massiv=new int[10];

FillMas(massiv);
PrintMas(massiv);

int ind=0;
int n1=0;
int n2=0;

while(ind<massiv.Length)
{
    if (massiv[ind]%2==0)
    {  
        n1++;
    }
    else
    {
        n2++;
    }
    ind++;   
}
Console.WriteLine("Вывод количества четных чисел: " + n1);
Console.WriteLine("Вывод количества нечетных чисел: " + n2);
