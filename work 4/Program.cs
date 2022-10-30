double x1 = 0;
double x2 = Math.PI;

int n = 1000;

double step = (x2 - x1) / n;
double s = 0;
for (int i = 1; i < n - 1; i++)
{
    double x = x1 + step * i;
    s += Math.Sin(x);
}
double sTotal = step * ((Math.Sin(x1) + Math.Sin(x2)) / 2 + s);
Console.WriteLine(sTotal);

