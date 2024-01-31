namespace SOLIDPrinciples_04.Solution.LSP;

public abstract class Account
{
    public abstract void Deposit(decimal amount);
    public decimal Balance { get; protected set; }
}