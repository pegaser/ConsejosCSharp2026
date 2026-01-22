namespace CSharp.News.NullConditionalAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string language = null;

            language ??= "Español";

            Console.WriteLine($"Idioma seleccionado: {language}");
            Console.ReadKey();
        }
    }
}
