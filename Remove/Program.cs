namespace Remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lastNumber = numbers[numbers.Count - 1];
            while (numbers.Contains(lastNumber))
            {
                numbers.Remove(lastNumber);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
