namespace SOLIDPrinciples_04.Solution.LSP;

public class CurrentAccount : WithdrawableAccount
{
    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        Balance -= amount; // Current accounts may allow overdrafts
    }
}