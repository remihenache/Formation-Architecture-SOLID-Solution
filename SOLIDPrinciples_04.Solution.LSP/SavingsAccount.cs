namespace SOLIDPrinciples_04.Solution.LSP;

public class SavingsAccount : WithdrawableAccount
{
    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds");
        }
    }
}