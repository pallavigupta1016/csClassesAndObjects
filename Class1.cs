namespace ClassesAndObjects
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double m = 1000;
            Console.WriteLine("Enter the monthly payment:");
            double n = double.Parse(Console.ReadLine());
            double balance = 0;
            double tpayment = 0;
            int month = 0;
            while (m > 0)
            {
                month += 1;
                balance = 1.015 * m - n;
                tpayment += n;
                m = balance;
                Console.WriteLine("Month: {0} balance: {1} total payments: {2}",month,balance,tpayment);
            }
        }
    }
}