namespace ClassTasks;

public class BankAccount
{
    public string Owner { get; private set; } //property

    public decimal Balance { get; private set; } = 0; //property

    // constructor
    public BankAccount(string owner)
    {
        Owner = owner;
    }

    // methods
    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine($"Deposit amount cannot be negative: {amount}");
        }
        else
        {
            Balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine($"Withdraw amount cannot be negative: {amount}");
        } 
        else if (amount > Balance)
        {
            Console.WriteLine($"Withdraw amount cannot be greater than balance: {amount}");
        }
        else
        {
            Balance -= amount;
        }
    }
    
    public string PrintInfo()
    {
        return $"Owner: {Owner}, Balance: {Balance}";
    }
}