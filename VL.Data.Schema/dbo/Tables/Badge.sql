CREATE TABLE [dbo].[Badge] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Number]           VARCHAR (50) NOT NULL,
    [IsActive]         BIT          CONSTRAINT [DF_Badge_IsActive] DEFAULT ((0)) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) CONSTRAINT [DF_Badge_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]      DATETIME     CONSTRAINT [DF_Badge_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) CONSTRAINT [DF_Badge_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]     DATETIME     CONSTRAINT [DF_Badge_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Badge] PRIMARY KEY CLUSTERED ([ID] ASC)
);

