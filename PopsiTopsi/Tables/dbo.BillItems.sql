CREATE TABLE [dbo].[BillItems] (
  
    [Quantity]   INT NOT NULL,
    [Bill_Id]    INT NOT NULL,
    [Article_Id] INT NOT NULL,
    CONSTRAINT [pk_billitems] PRIMARY KEY CLUSTERED ( [Bill_Id] ASC, [Article_Id] ASC),
    CONSTRAINT [fk_bills] FOREIGN KEY ([Bill_Id]) REFERENCES [dbo].[Bills] ([Id]),
    CONSTRAINT [fk_articles] FOREIGN KEY ([Article_Id]) REFERENCES [dbo].[Articles] ([Id])
);

