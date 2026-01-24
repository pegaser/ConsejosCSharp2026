namespace CSharp.News.ImplicitSpanConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Span<int> middle = numbers.AsSpan(1, 3);


            Console.WriteLine("Primeros tres números:");
            foreach (var n in middle)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
