using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialBalance = 10250;
        double expected = 10250;

        // Act
        BankAccount account = new BankAccount(initialBalance);
        double result = account.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initialBalance = 250;
        BankAccount account = new BankAccount(initialBalance);
        double depositAmount = 50;
        double expected = 300;

        // Act
        account.Deposit(depositAmount);
        double result = account.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 250;
        BankAccount account = new BankAccount(initialBalance);
        double depositAmount = -50;

        // Act & Assert
        Assert.That(() => account.Deposit(depositAmount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialBalance = 250;
        BankAccount account = new BankAccount(initialBalance);
        double withdrawAmount = 50;
        double expected = 200;

        // Act
        account.Withdraw(withdrawAmount);
        double result = account.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 250;
        BankAccount account = new BankAccount(initialBalance);
        double withdrawamount = -50;

        // Act & Assert
        Assert.That(() => account.Withdraw(withdrawamount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 250;
        BankAccount account = new BankAccount(initialBalance);
        double withdrawAmount = 300;

        // Act & Assert
        Assert.That(() => account.Withdraw(withdrawAmount), Throws.ArgumentException);
    }
}
