int a1 = 23, b1 = 333, c1 = 67,
    a2 = 49, b2 = 50, c2 = 95,
    a3 = 22, b3 = 41, c3 = 5;
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
int max = Max(
    Max(a1, b1, c1),    // та же самая запись, что и закоментили выше,
    Max(a2, b2, c2),    // это отсылки к функциональному программированию
    Max(a3, b3, c3));
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
Console.Write("max = ");
Console.WriteLine(max);