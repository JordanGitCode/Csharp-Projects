using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftware.Models
{
    class BankAccount : Bank
    {

        private readonly int _id;
        private string _name { get; set; }
        private CreditCard _creditCard { get; set; }
        private int balance { get; set; }
        private int spendLimit { get; set; }

        public BankAccount(int id, string name, CreditCard creditCard, int balance, int spendLimit)
        {
            _id = id;
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _creditCard = creditCard ?? throw new ArgumentNullException(nameof(creditCard));
            this.balance = balance;
            this.spendLimit = spendLimit;
        }
    }
}
