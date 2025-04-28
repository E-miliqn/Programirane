namespace N_system
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
            string result = "";
            while (decimalNumber > 0)
            {
                int ost = decimalNumber % Nsystem;
                result = ost.ToString() + result;
                decimalNumber /= Nsystem;
            }

            Console.WriteLine(result);
        }
    }
}
    

