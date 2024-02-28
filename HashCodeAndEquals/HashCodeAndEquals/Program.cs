
using HashCodeAndEquals.Entities;

namespace HashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@mail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@mail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}