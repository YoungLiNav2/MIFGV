CREATE TABLE [dbo].people
(
	[ContactID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Last Call] DATETIME NULL, 
    [Name] NVARCHAR(50) NULL, 
    [Client] BIT NULL, 
    [Company] NVARCHAR(50) NULL, 
    [Telephone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL
)
