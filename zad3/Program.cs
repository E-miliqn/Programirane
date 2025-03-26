namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string[] b = { "Ivan", "Dimitrov", "Maria", "Ivanova", "Dimitar", "Petrov" };
            names.AddRange(b);
            for (int i = 0; i < b.Length - 1; i++)
            {
                names.Reverse();
                Console.WriteLine(string.Join(" ", names));
            }
        }
    }
}
