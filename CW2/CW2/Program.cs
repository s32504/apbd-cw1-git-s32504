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

static double GetAverage(int[] numbers)

{
    double sum = 0;
    if (numbers.Length == 0)
    {
        return 0;
    }

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        sum += numbers[i];

    }

    return sum / numbers.Length;
}

static int CalculateMinAddingConflict(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.");

    int smallest = values[0];
    
    foreach (int num in values)
    {
        if (num < smallest)
            smallest = num;
    }
    //Komentarz dla rebasa i z jakiegoś powodu moje prywatne konto połączyło się z Riderem???
    //testing?
    //Dobra, a teraz?
    //Test?
    return smallest;
}