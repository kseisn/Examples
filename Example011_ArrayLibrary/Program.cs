void FillArray(int[] collection) // определили массив
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // распечатали массив
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int pos = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            pos = index;
            break;
        }
        index++;
    }
    return pos;
}

int[] array = new int[10];
            // создай новый массив с 10-ю элементами
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
int P = IndexOf(array, 4);
Console.WriteLine(P);