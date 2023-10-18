int Factorial(int nums)
{
    int res = 1;
    for (int i = nums; i > 1; i--)
        res *= i;
    return res;
}

void SumCalculate(double e, out double sum, int n, out int count) 
{ 
    sum = 0;
    count = 0;
    int k = 0;
    double a = 1;

    while (Math.Abs(a) > e)
    {
        a = Math.Pow(a, 2 * k) / Factorial(2 * k);
        sum += a;
        k++;
        count++;
    }

}

double s;
int c;
SumCalculate(0.00001, out s, 1000, out c);
Console.WriteLine($"Сумма ряда с заданной точностью epsilon: {Math.Cos(s)}");
Console.WriteLine($"Точность достигается на шаге: {c}");

