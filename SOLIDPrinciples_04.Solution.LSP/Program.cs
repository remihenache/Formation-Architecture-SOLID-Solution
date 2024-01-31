namespace SOLIDPrinciples_04.Solution.LSP;

public static class Program
{
    public static void Main(string[] args)
    {
        WithdrawableAccount account = new SavingsAccount();
        account.Deposit(new decimal(1000.00));

        BankingAppWithdrawalService withdrawalService = new BankingAppWithdrawalService(account);
        withdrawalService.Withdraw(new decimal(100.00));
        
        Account account2 = new FixedTermDepositAccount();
        BankingAppWithdrawalService withdrawalService2 = new BankingAppWithdrawalService(account2);
        withdrawalService.Withdraw(new decimal(100.00));
    }
}