int[] scores = new int[7];
int count = 0;
for (int i = 0; i < scores.Length; i++)
{
    Console.Write($"Результат {i + 1}: ");
    scores[i] = Convert.ToInt32(Console.ReadLine());
}


System.Console.WriteLine($"Сумма: {SumArray(scores)}");
System.Console.WriteLine($"Минимум: {FindMin(scores)}");
System.Console.WriteLine($"Максимум: {FindMax(scores)}");
System.Console.WriteLine($"Результатов 50 и больше: {CountAtLeast(scores, 50)}");
System.Console.Write("Какой результат найти: ");
int target = int.Parse(Console.ReadLine());
if (FindIndex(scores, target) == -1)
{
    System.Console.WriteLine("Результат не найден");
}
else
{
    System.Console.WriteLine($"Первый индекс: {FindIndex(scores, target)}");
}

int[] values = { 1, 2 };
Console.WriteLine(CalculateAverage(values));

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
int FindIndex(int[] numbers, int target)
{
    int index = -1;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }

    return index;
}
double CalculateAverage(int[] numbers)
{
    double sum = SumArray(numbers);
    double average = sum / numbers.Length;
    return average;
}