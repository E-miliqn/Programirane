namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = list.Max();
            int min = list.Min();
            Console.WriteLine(min + " " + max);
            
        }
    }
}
