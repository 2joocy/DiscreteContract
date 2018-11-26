using System;

namespace ConsoleApp1
{
    class Program
    {

        public static Account acc;

        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.setBalance(1000);
            negativeDeposit();
            negativeWithdraw();
            largeWithdraw();
        }

        public static void negativeDeposit() {
            acc.deposit(-100);
        }

        public static void negativeWithdraw() {
            acc.withdraw(-100);
        }

        public static void largeWithdraw() {
            acc.withdraw(2000);
        }


    }
}
