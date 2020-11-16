using System;
namespace Banking.Models.Domain
{
    public class BankAccount
    {
        private readonly string _accountNumber;
        private decimal _balance;
        private const decimal WithdrawCost = 0.25M;

    }
}
