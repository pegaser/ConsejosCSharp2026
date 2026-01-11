namespace CSharp.News.Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "   ";
            if (texto.IsEmptyIgnoringSpaces)
            {
                Console.WriteLine("El texto está vacío");
            }
            Console.ReadKey();
        }
    }
    public static class StringExtensions
    {
        extension(string text)
        {
            public bool IsEmptyIgnoringSpaces
            {
                get => string.IsNullOrWhiteSpace(text);
            }
        }
    }
}
