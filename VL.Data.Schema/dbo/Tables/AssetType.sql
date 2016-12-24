CREATE TABLE [dbo].[AssetType] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) CONSTRAINT [DF_AssetType_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]      DATETIME     CONSTRAINT [DF_AssetType_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) CONSTRAINT [DF_AssetType_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]     DATETIME     CONSTRAINT [DF_AssetType_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_AssetType] PRIMARY KEY CLUSTERED ([ID] ASC)
);







