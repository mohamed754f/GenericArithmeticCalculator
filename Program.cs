namespace GenericArithmeticCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intgerNumber = new Calculator<int>();
            Console.WriteLine("Int Calculations:");
            Console.WriteLine($"ADD: {intgerNumber.AddNumber(43, 34)}");
            Console.WriteLine($"Subtract: {intgerNumber.SubstrctNumber(32, 76)}");
            Console.WriteLine($"Multiply: {intgerNumber.MultiplicatNumber(23, 7)}");
            Console.WriteLine($"Divide: {intgerNumber.DivisionNumber(34, 56)}");

            var doubleNumber = new Calculator<double>();
            Console.WriteLine("\nDouble Calculations:");
            Console.WriteLine($"Add: {doubleNumber.AddNumber(54.3, 4.8)}");
            Console.WriteLine($"Subtract: {doubleNumber.SubstrctNumber(14.5, 9.6)}");
            Console.WriteLine($"Multiply: {doubleNumber.MultiplicatNumber(45.12, 7.3)}");
            Console.WriteLine($"Divide: {doubleNumber.DivisionNumber(65.25, 5.2)}");
        }
    }
}
