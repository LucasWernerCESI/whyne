CREATE TABLE [dbo].[ProviderTable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Location] NVARCHAR(50) NULL, 
    [Product] NVARCHAR(MAX) NULL
)
