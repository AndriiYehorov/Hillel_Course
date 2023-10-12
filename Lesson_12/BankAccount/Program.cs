namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankSavingsAccount = new SavingsAccount("Me", 5000, 0.05);

            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankSavingsAccount.Withdraw(1000);
            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankSavingsAccount.Deposit(8000);
            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();

            BankAccount bankSavingsAccount_2 = new SavingsAccount("You", 8000, 0.05);
            bankSavingsAccount_2.DisplayAccountInfo();
            Console.WriteLine();

            BankAccount bankCheckingAccount = new CheckingAccount("Friend", 12500, 10000);
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankCheckingAccount.Withdraw(19500);
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankCheckingAccount.Deposit(9000);
            bankCheckingAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankCheckingAccount.Withdraw(13000);
            bankCheckingAccount.DisplayAccountInfo();




        }
    }
}