namespace ComplexNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber cn = new ComplexNumber(-8,12);
            Console.WriteLine(cn.ToString());
            Console.WriteLine($"Absolute Value: {cn.AbsoluteValue():F2}");
            ComplexNumber sum = cn + cn;
            Console.WriteLine(sum.ToString());
            double number = (double)sum;
            Console.WriteLine(number);
            double num1 = 5.9;
            ComplexNumber implicted = new ComplexNumber();
            implicted = num1;
            Console.WriteLine(implicted.ToString());
        }
    }
}