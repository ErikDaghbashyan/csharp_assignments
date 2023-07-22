namespace ComplexNumber
{
    internal class ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }
        public ComplexNumber() :this(1,1){ }
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }
        public double AbsoluteValue()
        {
            return Math.Sqrt(RealPart* RealPart+ImaginaryPart*ImaginaryPart);
        }
        public static ComplexNumber operator+(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.RealPart+b.RealPart,a.ImaginaryPart+b.ImaginaryPart);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.RealPart - b.RealPart, a.ImaginaryPart - b.ImaginaryPart);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.RealPart * b.RealPart, a.ImaginaryPart * b.ImaginaryPart);
        }
        public static implicit operator ComplexNumber(double n)
        {
            return new ComplexNumber(n, 0);
        }
        public static explicit operator double(ComplexNumber cn)
        {
            return cn.RealPart;
        }
        public override string ToString()
        {
            //if (ImaginaryPart < 0)
            //    if (ImaginaryPart == -1) return $"{RealPart}-i";
            //    else  return $"{RealPart}{ImaginaryPart}i";
            //else if (ImaginaryPart == 1)return $"{RealPart}+i";
            //else  return $"{RealPart}+{ImaginaryPart}i";
            return $"( {RealPart} , {ImaginaryPart} )";
        }
    }
}
