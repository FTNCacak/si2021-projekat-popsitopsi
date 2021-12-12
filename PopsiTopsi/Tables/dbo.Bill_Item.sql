CREATE TABLE [dbo].[BillItems]
(
	[Id] INT NOT NULL IDENTITY, 
    [Quantity] INT NOT NULL, 
    [Bill_Id] INT NOT NULL,
	[Stuff_Id] INT NOT NULL, 
    [Article_Id] INT NOT NULL,
	
    CONSTRAINT fk_bill FOREIGN KEY (Bill_Id,Stuff_Id) REFERENCES Bills(Id,Stuff_Id),
	CONSTRAINT fk_article FOREIGN KEY (Article_Id) REFERENCES Articles(Id),
	CONSTRAINT pk_billitems PRIMARY KEY (Id,Bill_Id,Stuff_Id,Article_Id)

)
