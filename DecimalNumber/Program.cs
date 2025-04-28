namespace DecimalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int Nsystem = int.Parse(input[0]);
            int decimalNumber = int.Parse(input[1]);

            if (Nsystem < 2 || Nsystem > 10)
            {
                Console.WriteLine("Невалидна основа. Въведете основа между 2 и 10.");
                return;
            }
            
        }
    }
}
