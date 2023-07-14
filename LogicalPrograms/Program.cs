using LogicalPrograms;

namespace LineComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci f = new Fibonacci();
           


            Console.WriteLine("Logical programs: ");
            Console.WriteLine("\n1.Fibonacci Series ");

            int count = Convert.ToInt32(Console.ReadLine());
            
            switch (count)
            {
                case 1:
                    int n = Convert.ToInt32(Console.ReadLine());
                    f.FibonacciSeries();
                    break;
            }
        }
    }

}