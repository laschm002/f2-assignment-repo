using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class Customer : Person
    {
        private double adjustedCreditScore;
        int bankAccountNum;
         double bankBalance;
         double creditScore;
         string dateCreated;
        

        public Customer(string NameFirst, string NameLast, string BirthDate, int Social, int BankAccountNum, double BankBalance, double CreditScore, string DateCreated)
        {

            nameFirst = NameFirst;
            nameLast = NameLast;
            birthDate = BirthDate;
            social = Social;
            bankAccountNum = BankAccountNum;
            bankBalance = BankBalance;
            creditScore = CreditScore;
            dateCreated = DateCreated;


        }

        public double AdjustAccountBalance()
        {
            bankBalance += 1000;
            return bankBalance;
        }
        public double CalculateCreditScore()
        {
             adjustedCreditScore = creditScore + (bankBalance / 10 );

            return adjustedCreditScore;
            
        }
    }
}
