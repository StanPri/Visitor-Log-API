CREATE TABLE [dbo].[Permission] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)   NOT NULL,
    [Description] VARCHAR (1000) NULL,
    CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED ([ID] ASC)
);

