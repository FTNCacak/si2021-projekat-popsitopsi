CREATE TABLE [dbo].[Articles]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(30) NOT NULL, 
    [Type] NVARCHAR(20) NOT NULL, 
    [Price] DECIMAL(16, 2) NOT NULL, 
    [Image] IMAGE NOT NULL, 
    [Description] NVARCHAR(MAX) NULL,
	CONSTRAINT pk_article PRIMARY KEY (Id)
)
