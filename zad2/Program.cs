namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string[] b = { "Ivan", "Maria", "Dimitar", "Simona", "Petya" };
            names.AddRange(b);
            names.Reverse();
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
