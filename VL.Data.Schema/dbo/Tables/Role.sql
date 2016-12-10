CREATE TABLE [dbo].[Role] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)   NOT NULL,
    [Description] VARCHAR (1000) NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([ID] ASC)
);

