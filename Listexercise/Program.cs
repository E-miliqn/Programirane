namespace Listexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(list[0]);
            int halfIndex = list.Count / 2;
            Console.WriteLine(list[halfIndex] + "index = " + halfIndex);
            Console.WriteLine(list[list.Count - 1]);
            Console.WriteLine(string.Join("-", list));
            int s = 0;
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"[{i}] = {list[i]}");
                if (list[i] > 0)
                {
                    s += list[i]; //i е мястото на клетката, а list[i] е числото, което стои в тази клетка
                    count++;
                }
            }
            double avr = (double)s / count;
            Console.WriteLine($"средно аритметично =  {avr:f2}");
        }
    }
}
