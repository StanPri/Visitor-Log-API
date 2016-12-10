CREATE TABLE [dbo].[BadgeType] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [Code]        VARCHAR (10) NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    [ts]          ROWVERSION   NOT NULL,
    CONSTRAINT [PK_BadgeType] PRIMARY KEY CLUSTERED ([ID] ASC)
);

