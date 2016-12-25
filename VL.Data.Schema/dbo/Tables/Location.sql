CREATE TABLE [dbo].[Location] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [Floor]            INT          CONSTRAINT [DF_Location_Floor] DEFAULT ((0)) NOT NULL,
    [Room]             VARCHAR (50) NULL,
    [Phone]            VARCHAR (50) NULL,
    [IsActive]         BIT          CONSTRAINT [DF_Location_IsActive] DEFAULT ((0)) NOT NULL,
    [CreatedByUserID]  VARCHAR (50) CONSTRAINT [DF_Location_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]      DATETIME     CONSTRAINT [DF_Location_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) CONSTRAINT [DF_Location_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]     DATETIME     CONSTRAINT [DF_Location_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([ID] ASC)
);



