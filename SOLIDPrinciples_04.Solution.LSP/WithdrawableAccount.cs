namespace SOLIDPrinciples_04.Solution.LSP;

public abstract class WithdrawableAccount : Account
{
    public abstract void Withdraw(decimal amount);
}