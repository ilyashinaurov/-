var rand = new Random();
var mass = new int[100];

int positive = 0;
int negative = 0;

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(int.MinValue, int.MaxValue);
}

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] < 0)
    {
        negative += 1;
    }
    else
    {
        positive += 1;
    }
}

var positiveMass = new int[positive];
var negativeMass = new int[negative];

for (int i = 0; i < positiveMass.Length; i++)
{
    if (positiveMass[i] < 0)
    {
        continue;
    }
    if (mass[i] > 0)
    {
        positiveMass[i] += mass[i];
    }
}

for (int i = 0; i < negativeMass.Length; i++)
{
    if (negativeMass[i] > 0)
    {
        continue;
    }
    if (mass[i] < 0)
    {
        negativeMass[i] += mass[i];
    }

}

