CREATE TABLE [dbo].[Bills]
(
	[Id] INT NOT NULL IDENTITY, 
    [Total] DECIMAL(16, 2) NOT NULL, 
    [Date] DATE NOT NULL, 
    [Stuff_Id] INT NOT NULL,
	CONSTRAINT fk_stuffs FOREIGN KEY(Stuff_Id) REFERENCES Stuffs(Id),
	CONSTRAINT pk_bills PRIMARY KEY (Id,Stuff_Id)

)
