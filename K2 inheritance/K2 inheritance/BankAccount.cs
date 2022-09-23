using System.Security.Cryptography.X509Certificates;

namespace K2_inheritance
{
    public class BankAccount  
    {
        //    a.A bank account has a balance, a borrowing rate, and a savings rate.
        //The borrowing rate might be 10% but the savings rate might be only 1%.
        //b.Add methods to deposit and withdraw money.
        //    c.Add a method to accrue or charge interest depending on the current balance.
        //    d.Ensure, via proper encapsulation, that the following invariants are true:
        //i.the balance must never be less than −100, 000,
        //    ii.the balance must never be more than 250,000,
        //    iii.you cannot deposit or withdraw a negative amount of money
        //    iv.the borrowing rate must be at least 6%. The savings rate must be at most 2%}
        protected double Balance;
        protected double BorrowingRate = 0.1;
        protected double SavingsRate = 0.01;
        public double GetBalance()
        { 
            return Balance; 
        }
        public void AmountPositiveCheck(double amount)
        {
            if (amount < 0)
                throw new System.Exception("Amount cannot be negative");
        }
        public void Deposit(double Amount)
        {
            AmountPositiveCheck(Amount);
            if (Balance + Amount > 250000)
            {
                throw new System.Exception("Balance too high");
            }
            Balance += Amount + Amount * SavingsRate;
        }
        public void Withdraw(double Amount)
        {
            AmountPositiveCheck(Amount);
            if (Balance - Amount < -100000)
            {
                throw new System.Exception("Balance too low");
            }
            Balance -= Amount - Amount * SavingsRate;
        }
    }
}
