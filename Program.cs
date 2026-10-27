int[] scores = { 60, 80, 40, 80, 90 };
int count = 0;

Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));
Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));
System.Console.WriteLine(FindMax(scores));
System.Console.WriteLine(FindMin(scores));
Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));
int SumArray(int[] numbers)
{
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
}
int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;

    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }

    return count;
}

int FindMax(int[] numbers)
{
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }

    return max;
}
int FindMin(int[] numbers)
{
    int min = numbers[0];

    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }

    return min;
}