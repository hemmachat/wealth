using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Wealth.Models;

namespace Wealth.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Wealth.Models.WealthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WealthContext context)
        {
            context.Customers.AddOrUpdate(c => c.CustomerId,
                new Customer()
                {
                    CustomerId = 1,
                    Firstname = "Smith",
                    Lastname = "James",
                    AccountName = "Smith James",
                    AccountNumber = 1,
                    AccountBalance = 0,
                    ContactInformation = "Spouse"
                },
                new Customer()
                {
                    CustomerId = 2,
                    Firstname = "Jack",
                    Lastname = "James",
                    AccountName = "Jack Smith",
                    AccountNumber = 2,
                    AccountBalance = 0,
                    ContactInformation = "Spouse"
                }
            );

            context.Transactions.AddOrUpdate(t => t.TransactionId,
                new Transaction()
                {
                    TransactionId = 1,
                    CustomerId = 1,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Credit
                },
                new Transaction()
                {
                    TransactionId = 2,
                    CustomerId = 1,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Credit
                },
                new Transaction()
                {
                    TransactionId = 3,
                    CustomerId = 1,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Credit
                },
                new Transaction()
                {
                    TransactionId = 4,
                    CustomerId = 1,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Credit
                },
                new Transaction()
                {
                    TransactionId = 5,
                    CustomerId = 1,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Credit
                },
                new Transaction()
                {
                    TransactionId = 6,
                    CustomerId = 2,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Debit
                },
                new Transaction()
                {
                    TransactionId = 7,
                    CustomerId = 2,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Debit
                },
                new Transaction()
                {
                    TransactionId = 8,
                    CustomerId = 2,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Debit
                },
                new Transaction()
                {
                    TransactionId = 9,
                    CustomerId = 2,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Debit
                },
                new Transaction()
                {
                    TransactionId = 10,
                    CustomerId = 2,
                    DollarValue = 0,
                    TransactionDate = DateTime.Now,
                    TransactionType = TransactionType.Debit
                }
            );
        }
    }
}
