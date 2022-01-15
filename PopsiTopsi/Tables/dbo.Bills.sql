CREATE TABLE [dbo].[Bills] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [Total]    DECIMAL (16, 2) NOT NULL,
    [Date]     DATE            NOT NULL,
    [Id_Stuff] INT             NOT NULL,
    CONSTRAINT [pk_bills] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_stuffs] FOREIGN KEY ([Id_Stuff]) REFERENCES [dbo].[Stuffs] ([Id])
);

