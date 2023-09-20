namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double oper1, oper2, result;
            Operation operation;

            Console.Write("Введіть перший операнд ");
            oper1 = GetDoubleNumber();
            Console.Write("Введіть другий операнд ");
            oper2 = GetDoubleNumber();
            Console.Write("Введіть операцію 1- +, 2 - -, 3 - *, 4 - /   ");
            operation = GetOperation();
            result = DoOperation(oper1, oper2, operation);
            Console.WriteLine("{0} {1} {2} = {3}", oper1, operation, oper2, result);
        }

        static Operation GetOperation()
        {
            bool check;
            byte res;
            do
            {
                string input = Console.ReadLine();
                check = byte.TryParse(input, out res);
            }
            while (!check || res < (byte)Operation.Add || res > (byte)Operation.Divide);
            var allValues = Enum.GetValues(typeof(Operation));
            return (Operation)allValues.GetValue(res-1);
        }

        static double GetDoubleNumber()
        {
            double number;
            bool resParse = false;
            do
            {
                string input = Console.ReadLine();
                resParse = double.TryParse(input, out number);
            }
            while (!resParse);
            return number;
        }

        static double DoOperation(double oper1, double oper2, Operation operation)
        {
            double result;
            switch (operation)
            {
                case Operation.Add:
                    result = oper1 + oper2;
                    break;
                case Operation.Subtract:
                    result = oper1 - oper2;
                    break;
                case Operation.Multiply:
                    result = oper1 * oper2;
                    break;
                case Operation.Divide:
                    result = oper1 / oper2;
                    break;
                default: throw new ArgumentException();
            }
            return result;
        }
    }
}