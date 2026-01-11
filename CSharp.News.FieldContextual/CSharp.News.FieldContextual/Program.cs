namespace CSharp.News.FieldContextual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.Age = 25;   // correcto
            person.Age = -3;   // muestra mensaje y no asigna
            Console.ReadKey();
        }
    }

    internal class Person
    {
        public int Age
        {
            get => field;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("La edad no puede ser negativa");
                    return;
                }

                field = value;
            }
        }

    }
}
