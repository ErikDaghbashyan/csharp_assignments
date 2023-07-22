namespace StringBulder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing ctor and Append:\n...");
            StringBuilder sb = new StringBuilder("12345678901234567890123456");
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.ToString());

            sb.Append('a');
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.ToString());

            sb.Append("890123456");
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.ToString());

            sb.Append("veryyyyy looong Senteeensssseeee");
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.ToString());

            Console.WriteLine("\nTesting IssertAt function:\n...");
            sb.InsertAt(3, "Helllloo");
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.ToString());

            Console.WriteLine("\nTesting RemoveDuplicates function:\n...");
            sb.RemoveDuplicates();
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.ToString());

            Console.WriteLine("\nTesting RemoveWhitespaces function:\n...");
            StringBuilder sb1 = new StringBuilder(" a  b\n\n  c");
            Console.WriteLine(sb1.ToString());
            sb1.RemoveWhitespaces();
            Console.WriteLine(sb1.ToString());

            Console.WriteLine("\nTesting IsBlank and Onblank function:\n...");
            StringBuilder sb2 = new StringBuilder("");
            Console.WriteLine(sb2.IsBlank());

            Console.WriteLine(sb2.OnBlank("string"));
            Console.WriteLine(sb1.OnBlank("string"));
        }
    }
}