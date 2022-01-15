CREATE TABLE [dbo].[Articles] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (30)   NOT NULL,
    [Type]        NVARCHAR (20)   NOT NULL,
    [Price]       DECIMAL (16, 2) NOT NULL,
    [Image]       NVARCHAR(MAX)           NOT NULL,
    [Description] NVARCHAR (MAX)  NULL,
    CONSTRAINT [pk_article] PRIMARY KEY CLUSTERED ([Id] ASC)
);

