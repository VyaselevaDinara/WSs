internal class Program
{
    static double Factorial(double num)
    {
        double facty = 1;
        for (double j = 1; j <= num; j++)
        {
            facty *= j;
        }
        return facty;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите значение числа n");
        double N = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение числа x");
        double X = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        for (double i = 0; i <= N; i++)
        {
            result += Math.Pow(-1, i) * Math.Pow(X, i) / Factorial(i);
        }
        Console.WriteLine(result);
    }
}
