CREATE TABLE [dbo].[BadgeType] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Code]             VARCHAR (10) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifedDate]      DATETIME     NOT NULL,
    CONSTRAINT [PK_BadgeType] PRIMARY KEY CLUSTERED ([ID] ASC)
);



