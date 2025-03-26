namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"number[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            
        }
    }
}
