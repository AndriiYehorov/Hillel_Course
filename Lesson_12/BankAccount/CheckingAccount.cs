namespace BankAccount
{
    internal class CheckingAccount : BankAccount
    {
        double overdraftLimit;
        public CheckingAccount(string accountHolder, double balance, double overdraftLimit) : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override double Deposit(double amount)
        {
            balance = balance+amount;
            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Balance = {balance}");
            Console.WriteLine($"AccountHolder = {accountHolder}");
            Console.WriteLine($"AccountNumber = {accountNumber}");
            Console.WriteLine($"overdraftLimit = {overdraftLimit}");
        }

        public override double Withdraw(double amount)
        {
            if (amount <= (balance + overdraftLimit))
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("limit is exceeded");
            }
            return balance;
        }
    }
}