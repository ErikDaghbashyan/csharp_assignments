namespace StringLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrLinkedList sList = new StrLinkedList();
            sList.Append("Hello");
            sList.Append(" me");

            Console.WriteLine(sList.ToString());

            sList.InsertAt(5, " Ooh");
            Console.WriteLine(sList.ToString());

            sList.RemoveWhitespaces();
            Console.WriteLine(sList.ToString());
        }
    }
}