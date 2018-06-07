CREATE TABLE [dbo].[Customers] (
    [CustomerId] [int] NOT NULL IDENTITY,
    [Firstname] [nvarchar](max),
    [Lastname] [nvarchar](max),
    [AccountNumber] [int] NOT NULL,
    [AccountName] [nvarchar](max),
    [AccountBalance] [decimal](18, 2) NOT NULL,
    [ContactInformation] [nvarchar](max),
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY ([CustomerId])
)
CREATE TABLE [dbo].[Transactions] (
    [TransactionId] [int] NOT NULL IDENTITY,
    [CustomerId] [int] NOT NULL,
    [DollarValue] [decimal](18, 2) NOT NULL,
    [TransactionDate] [datetime] NOT NULL,
    [TransactionType] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Transactions] PRIMARY KEY ([TransactionId])
)
go

SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT INTO [dbo].[Customers] ([CustomerId], [Firstname], [Lastname], [AccountNumber], [AccountName], [AccountBalance], [ContactInformation]) VALUES (1, N'Smith', N'James', 1, N'Smith James', CAST(0.00 AS Decimal(18, 2)), N'Spouse')
INSERT INTO [dbo].[Customers] ([CustomerId], [Firstname], [Lastname], [AccountNumber], [AccountName], [AccountBalance], [ContactInformation]) VALUES (2, N'Jack', N'James', 2, N'Jack Smith', CAST(0.00 AS Decimal(18, 2)), N'Spouse')
SET IDENTITY_INSERT [dbo].[Customers] OFF
go

SET IDENTITY_INSERT [dbo].[Transactions] ON
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (1, 1, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 0)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (2, 1, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 0)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (3, 1, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 0)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (4, 1, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 0)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (5, 1, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 0)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (6, 2, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 1)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (7, 2, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 1)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (8, 2, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 1)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (9, 2, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 1)
INSERT INTO [dbo].[Transactions] ([TransactionId], [CustomerId], [DollarValue], [TransactionDate], [TransactionType]) VALUES (10, 2, CAST(0.00 AS Decimal(18, 2)), N'2018-06-07 14:42:33', 1)
SET IDENTITY_INSERT [dbo].[Transactions] OFF
go

