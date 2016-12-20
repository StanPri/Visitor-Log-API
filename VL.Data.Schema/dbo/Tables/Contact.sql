CREATE TABLE [dbo].[Contact] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [ContactUserID]    VARCHAR (50) NOT NULL,
    [Phone]            VARCHAR (50) NOT NULL,
    [Mobile]           VARCHAR (50) NULL,
    [CreatedByUserID]  VARCHAR (50) CONSTRAINT [DF_Contact_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]      DATETIME     CONSTRAINT [DF_Contact_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) CONSTRAINT [DF_Contact_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]     DATETIME     CONSTRAINT [DF_Contact_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([ID] ASC)
);



