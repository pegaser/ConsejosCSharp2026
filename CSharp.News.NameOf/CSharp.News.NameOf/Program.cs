namespace CSharp.News.NameOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age2 = 25;

            Console.WriteLine($"Mi variable se llama {nameof(age2)}");

            var repository = new Repository<int>();
            repository.ShowTypeName();

            Console.ReadKey();
        }
    }
    public class Repository<T>
    {
        public void ShowTypeName()
        {
            Console.WriteLine($"{nameof(Repository<>)}");

            throw new Exception($"Error en el repositorio {nameof(Repository<>)}");
        }
    }

}
