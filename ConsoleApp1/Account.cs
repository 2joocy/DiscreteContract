using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

    class Account
    {
        private float balance;

    public void setBalance(float balance) {
        this.balance = balance;
    }

        public void deposit(float deposit) {
            Contract.Requires<Exception>(deposit < 0, "Deposit value cannot be negative");
            balance += deposit;
        }

        public void withdraw(float deposit) {
            Contract.Requires<Exception>(deposit < 0, "Deposit value cannot be negative");
            Contract.Requires<Exception>(deposit > balance, "Cannot withdraw a larger amount than the balance");
            balance -= deposit;
            
        }

        public float getBalance() {
            return this.balance;
        }

    }
