﻿/*Problem 2. Bank accounts

A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.*/
namespace BankAccounts
{
    using System;

    public class BankAccountMain
    {
        public static void Main()
        {
            var customer = new DepositAccount(Customer.Individual, 3000, 6.7);
            var anotherCustomer = new MortgageAccount(Customer.Company, 15.5M, 9.9);

            Console.WriteLine(customer.CalculateInterestRate(12));

            Console.WriteLine(customer.Balance);

            customer.Deposit(505.5M);
            Console.WriteLine(customer.Balance);

            var accounts = new Bank("UBB");
            accounts.AddAccount(customer);
            accounts.AddAccount(anotherCustomer);

            Console.WriteLine(accounts.ToString());
        }
    }
}