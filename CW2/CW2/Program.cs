// See https://aka.ms/new-console-template for more information

Console.WriteLine("Jakim");
Console.WriteLine("cudem");
Console.WriteLine("mnie jeszcze");
Console.WriteLine("nie wyrzucili"); //yeah

static double GetMax(int[] numbers)

{
    double sum = 0;
    if (numbers.Length == 0)
    {
        return 0;
    }

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        if (numbers[i] > sum)
        {
            sum += numbers[i];
        }

    }
    return sum;
}



