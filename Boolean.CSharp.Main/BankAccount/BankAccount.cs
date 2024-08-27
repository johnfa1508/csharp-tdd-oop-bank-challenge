﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.BankAccount
{
    public class BankAccount
    {
        private string _accountName;
        private List<Transaction> _transactionHistory;
        private int _customerID;

        public string AccountName { get => _accountName; set => _accountName = value; }
        public List<Transaction> TransactionHistory { get => _transactionHistory; }
        public int CustomerID { get => _customerID; set => _customerID = value; }

        public BankAccount(string accountName, int customerID)
        {
            _accountName = accountName;
            _customerID = customerID;
        }


    }
}
