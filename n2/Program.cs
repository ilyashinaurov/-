var rand = new Random();
var mass = new int[100];

int firstRange = 0;
int secondRange = 0;
int thirdRange = 0;
int fourthRange = 0;
int fifthRange = 0;
int sixthRange = 0;
int sevenRange = 0;

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next();
}

for (int i = 0; i < mass.Length; i++)
{
    if ( 1 < mass[i] & mass[i] <10 )
    {
        firstRange += 1;
    }

    else if (11 < mass[i] & mass[i] < 100)
    {
        secondRange += 1;
    }

    else if (101 < mass[i] & mass[i] < 1000)
    {
        thirdRange += 1;
    }

    else if (1001 < mass[i] & mass[i] < 10000)
    {
        fourthRange += 1;
    }

    else if (10001 < mass[i] & mass[i] < 100000)
    {
        fifthRange += 1;
    }

    else if (100001 < mass[i] & mass[i] < 1000000)
    {
        sixthRange += 1;
    }

    else if (mass[i] > 1000001)
    {
        sevenRange += 1;
    }
}

Console.WriteLine($"1-10 - {firstRange}");
Console.WriteLine($"11-100 - {secondRange}");
Console.WriteLine($"101-1000 - {thirdRange}");
Console.WriteLine($"1001-10000 - {fourthRange}");
Console.WriteLine($"10001-100000 - {fifthRange}");
Console.WriteLine($"100001-1000000 - {sixthRange}");
Console.WriteLine($">1000001  - {sevenRange}");

