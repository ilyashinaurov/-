var rand = new Random();
var mass = new int[100];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next();
}

int minInd = 0;
int maxInd = 0;

int minVal = mass[0];
int maxVal = mass[0];

// минимальный
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] < minVal)
    {
        minVal = mass[i];
        minInd = i;
    }
}

// максимальный
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > maxVal)
    {
        maxVal = mass[i];
        maxInd = i;
    }
}

Console.WriteLine($"Максимальное значение {maxVal}, его индекс {maxInd}");
Console.WriteLine($"Минимально значение {minVal}, его индекс {minInd}");
