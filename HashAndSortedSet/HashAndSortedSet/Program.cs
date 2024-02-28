using System.Reflection.Metadata.Ecma335;

namespace HashAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Tablet"));

            foreach(string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}