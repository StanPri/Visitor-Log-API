CREATE TABLE [dbo].[Asset] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) CONSTRAINT [DF_Asset_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreateDate]       DATETIME     CONSTRAINT [DF_Asset_CreateDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) CONSTRAINT [DF_Asset_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]     DATETIME     CONSTRAINT [DF_Asset_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Asset] PRIMARY KEY CLUSTERED ([ID] ASC)
);



