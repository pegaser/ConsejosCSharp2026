
namespace CSharp.News.LambdaParameters
{
    internal class Program
    {
        delegate int RefOperation(ref int value);
        static void Main(string[] args)
        {
            RefOperation multiplyByTwoRef = (ref int value) => value * 2;

            int number = 5;
            int result = multiplyByTwoRef(ref number);

            Console.WriteLine("Resultado: " + result);
            Console.ReadKey();
        }
    }
}
