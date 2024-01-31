namespace SOLIDPrinciples_04.Solution.LSP;

public class BankingAppWithdrawalService {
    private WithdrawableAccount account;

    public BankingAppWithdrawalService(WithdrawableAccount account) {
        this.account = account;
    }

    public void Withdraw(decimal amount) {
        account.Withdraw(amount);
    }
}