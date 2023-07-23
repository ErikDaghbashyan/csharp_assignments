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
            ComplexNumber implicted = num1;
            Console.WriteLine(implicted.ToString());

            Console.WriteLine("\nToString function cases");
            ComplexNumber cn1=new ComplexNumber(-5,6);
            Console.WriteLine(cn1.ToString());
            ComplexNumber cn2 = new ComplexNumber(5, -6);
            Console.WriteLine(cn2.ToString());
            ComplexNumber cn3 = new ComplexNumber(5, 0);
            Console.WriteLine(cn3.ToString());
            ComplexNumber cn4 = new ComplexNumber(5, 1);
            Console.WriteLine(cn4.ToString());
        }
    }
}