CREATE TABLE [dbo].[BadgeType] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Code]             VARCHAR (10) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) CONSTRAINT [DF_BadgeType_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]      DATETIME     CONSTRAINT [DF_BadgeType_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) CONSTRAINT [DF_BadgeType_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifedDate]      DATETIME     CONSTRAINT [DF_BadgeType_ModifedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_BadgeType] PRIMARY KEY CLUSTERED ([ID] ASC)
);





