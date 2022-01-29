CREATE TABLE [dbo].[ItemsTable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Icon] VARCHAR(50) NULL, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [DegreeAlcoolo] FLOAT NULL, 
    [Familly] NVARCHAR(50) NULL, 
    [Quantity] INT NULL, 
    [Provider] NVARCHAR(50) NULL, 
    [Price] FLOAT NULL
)
