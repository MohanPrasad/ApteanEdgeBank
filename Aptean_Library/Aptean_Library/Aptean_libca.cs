using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptean_Library
{
    public class Customer
        {

        protected static int customerId;               //Each customer is assigned a customer identifier which is unique.
        string nameCustomer;                              //The customer’s name.
        DateTime dateOfJoining;                           //The date and time when the customer joined the Aptean Edge Bank.




        public Customer(string name, DateTime date)        //A new customer profile is created.
        {

            ++customerId;
            nameCustomer = name;
            dateOfJoining = date;

        }

        public void openAccount(int val)                          //  A new account, of a given type, can be opened/created for the customer.
        {


        }



    }

    public abstract class Accounts
    {
        int accountId;                   //Each account is assigned an account number which is unique. Account numbers of closed accounts cannot be reused.
        DateTime dateJoined;            //The date and time when the account was opened.
        DateTime dateClosed;            //The date and time when the account was closed.
        double balance;         //The current balance of the account. Values will be stored with 2 decimal places. The balance cannot be negative.

        public abstract double deposit(double amount);

        public abstract double withdraw(double amount);

        public abstract int close();


    }

    public class chequingAccount : Accounts
    {
        public static double balance = 0;

        public override double deposit(double amount)
        {
            return 0;

        }
        public override double withdraw(double demand)
        {
            return 0;

        }
        public override int close()
        {

            return 0;

        }
        public class tfsAccount : Accounts
        {
            public static double balance = 0;

            public override double deposit(double amount)
            {
                return 0;

            }
            public override double withdraw(double demand)
            {

                return balance;

            }

            public override int close()
            {

                return 0;

            }

        }


    }
}
