int sum = 0;

for (int i = -99; i < 0; i++)
{
    if (i % 2 != 0)
    {
        sum += Math.Abs(i);
    }
}

Console.WriteLine("Сумма модулей = " + sum);