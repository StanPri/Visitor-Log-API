CREATE TABLE [dbo].[Visitor] (
    [ID]                 INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]          VARCHAR (128) NOT NULL,
    [LastName]           VARCHAR (128) NOT NULL,
    [PersonIDCardNumber] VARCHAR (50)  NULL,
    [CreatedByUserID]    VARCHAR (50)  CONSTRAINT [DF_Visitor_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]        DATETIME      CONSTRAINT [DF_Visitor_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID]   VARCHAR (50)  CONSTRAINT [DF_Visitor_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]       DATETIME      CONSTRAINT [DF_Visitor_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Visitor] PRIMARY KEY CLUSTERED ([ID] ASC)
);





