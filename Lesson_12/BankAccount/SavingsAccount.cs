namespace BankAccount
{
    internal class SavingsAccount : BankAccount
    {
        double interestRate;
        public SavingsAccount(string accountHolder, double balance, double interestRate) : base(accountHolder, balance)
        {
            this.interestRate = interestRate;
        }
        public override double Deposit(double amount)
        {
            balance = balance * (1 + interestRate) + amount;
            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Balance = {balance}");
            Console.WriteLine($"AccountHolder = {accountHolder}");
            Console.WriteLine($"AccountNumber = {accountNumber}");
            Console.WriteLine($"InterestRate = {interestRate}");
        }

        public override double Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("amount > balance");
            }
            return balance;
        }
    }
}