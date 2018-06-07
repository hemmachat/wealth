namespace Wealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        AccountNumber = c.Int(nullable: false),
                        AccountName = c.String(),
                        AccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ContactInformation = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);

            CreateTable(
                "dbo.Transactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    CustomerId = c.Int(nullable: false),
                    DollarValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                    TransactionDate = c.DateTime(nullable: false),
                    TransactionType = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TransactionId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Transactions");
        }
    }
}
