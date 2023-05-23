int[] array = {13, 52, 38, 24, 59, 26, 71, 24, 68};
int n = array.Length;
int find = 24;
int index = 0;
while (index < n)
{
    if(array[index] == find) 
    {
        Console.Write("index = ");
        Console.WriteLine(index);
        break; // прерывает цикл
    }
    index++;
}