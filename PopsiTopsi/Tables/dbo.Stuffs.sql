CREATE TABLE [dbo].[Stuffs] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Surname]     NVARCHAR (50) NOT NULL,
    [Username]    NVARCHAR (20) NOT NULL,
    [Password]    NVARCHAR (20) NOT NULL,
    [PhoneNumber] NVARCHAR (20) NOT NULL,
    [Email]       NVARCHAR (100) NOT NULL,
    CONSTRAINT [pk_stuffs] PRIMARY KEY CLUSTERED ([Id] ASC)
);

