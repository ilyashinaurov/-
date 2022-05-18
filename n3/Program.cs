double Ratio(int size)
{
    var rand = new Random();

    var mass = new int[size];

    var values = new[] { 1, 0 };

    double ones = 0;
    double zeros = 0;


    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rand.Next(0, values.Length);
    }

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] == 1)
        {
            ones += 1;
        }
        else
        {
            zeros += 1;
        }
    }

    return ones / zeros;
}

Console.WriteLine($"100 элементов - отношение нулей и единиц равно {Ratio(100)}");
Console.WriteLine($"1000 элементов - отношение нулей и единиц равно {Ratio(1000)}");
Console.WriteLine($"10000 элементов - отношение нулей и единиц равно {Ratio(10000)}");
