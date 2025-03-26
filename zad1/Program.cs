using zad_2;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> evenNumbers = list.Where(n => n % 2 == 0).ToList();

            Console.WriteLine(string.Join(" ", evenNumbers));



        }
    }
}
