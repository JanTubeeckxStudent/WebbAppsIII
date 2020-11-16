using System;
namespace Banking.Models.Domain
{
    public class BankAccount
    {
        #region Fields
        private readonly string _accountNumber;
        private decimal _balance;
        private const decimal WithdrawCost = 0.25M;
        #endregion

        #region Properties
        public string AccountNumber { get; }

        public decimal Balance { get; private set; }
        #endregion

        #region Constructor
        public BankAccount(string account)
        {
            AccountNumber = account;
            Balance = Decimal.Zero;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion

    }
}
