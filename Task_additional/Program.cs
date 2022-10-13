// Найти 4 положительных числа сумма которых в 5 степени будет равна 5 числу в 5 степени. (1-300)

double SumPowers(double x, double y)
{
    double sum1 =
        Math.Pow(x, 5)
        + 5 * Math.Pow(x, 4) * y
        + 10 * Math.Pow(x, 3) * Math.Pow(y, 2)
        + 10 * Math.Pow(x, 2) * Math.Pow(y, 3)
        + 5 * x * Math.Pow(y, 4)
        + Math.Pow(y, 5);
    return sum1;
}

double x1 = new Random().Next(1, 10);
double x2 = new Random().Next(1, 10);
double x3 = new Random().Next(1, 10);
double x4 = new Random().Next(1, 10);

double sum = SumPowers((x1 + x2 + x3), x4);
double x5 = Math.Round(Math.Pow(SumPowers((x1 + x2 + x3), x4), 1.0 / 5), 0);

System.Console.WriteLine($"{x1}^5 + {x2}^5 + {x3}^5 + {x4}^5 = {x5}^5 ({sum})");

