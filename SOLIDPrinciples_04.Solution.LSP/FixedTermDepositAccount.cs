namespace SOLIDPrinciples_04.Solution.LSP;

public class FixedTermDepositAccount : Account
{
    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }
}