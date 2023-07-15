using LogicalPrograms;

namespace LineComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci f = new Fibonacci();
           


            Console.WriteLine("Logical programs: ");
            Console.WriteLine("\n1.Fibonacci Series \n2.Perfect Number \n3.PrimeNumber\n4.ReverseNumber\n5.Coupon\n6.StopWatch");

            int count = Convert.ToInt32(Console.ReadLine());
            
            switch (count)
            {
                case 1:
                    f.FibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.CheckPerfectNumber();
                    break;

                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.CheckPrimeNumber();
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.PrintReverseNumber();
                    break;
                case 5:
                    Coupon coupon = new Coupon();
                    Coupon.GetCoupon();
                    break;
                case 6:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.Run();
                    break;
               


            }
        }
    }

}