CREATE TABLE [dbo].[Bills]
(
	[Id] INT NOT NULL IDENTITY, 
    [Total] DECIMAL(16, 2) NOT NULL, 
    [Date] DATE NOT NULL, 
    [Id_Stuff] INT NOT NULL,
	CONSTRAINT fk_stuffs FOREIGN KEY(Id_Stuff) REFERENCES Stuffs(Id),
	CONSTRAINT pk_bills PRIMARY KEY (Id,Id_Stuff)

)
