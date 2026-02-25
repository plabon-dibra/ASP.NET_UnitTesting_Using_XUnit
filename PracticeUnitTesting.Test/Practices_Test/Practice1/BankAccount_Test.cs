using Xunit;
public class BankAccount_Test   
{
    [Fact]
    public void Deposit_Should_IncreaseBalance_By_100_BDT_When_amount_is_100_BDT()
    {
        BankAccount account = new BankAccount();
        decimal amount = 100;
        decimal expectedBalance = 100;
        account.Deposit(amount);
        Assert.Equal(expectedBalance, account.Balance);
    }

    [Fact]
    public void Diposit_Should_ThrowException_WhenAmountIsZeroOrNegative()
    {
        BankAccount account = new BankAccount();
        Assert.Throws<ArgumentException>(() => account.Deposit(0));
        Assert.Throws<ArgumentException>(() => account.Deposit(-10));
    }



    [Fact]
    public void Withdrawal_Should_ThrowException_WhenAmountIsZeroOrNegative()
    {
        var account = new BankAccount();
        Assert.Throws<ArgumentException>(() => account.Withdraw(0));
        Assert.Throws<ArgumentException>(() => account.Withdraw(-20));
    }

    [Fact]
    public void Withdrawal_Should_DecreaseBalance_By_100_BDT_When_amount_is_100_BDT()
    {
        BankAccount account = new BankAccount();
        account.Deposit(200);
        decimal amount = 100;
        decimal expectedBalance = 100;
        account.Withdraw(amount);
        Assert.Equal(expectedBalance, account.Balance);
    }

    [Fact]
    public void Withdrawal_Should_ThrowException_WhenAmountIsGreaterThanCurrentBalance()
    {
        var account = new BankAccount();
        account.Deposit(100);
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(101));
    }
}
