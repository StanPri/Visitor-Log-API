CREATE TABLE [dbo].[Log] (
    [ID]                  INT           IDENTITY (1, 1) NOT NULL,
    [StartDate]           DATETIME      NULL,
    [EndDate]             DATETIME      NULL,
    [Reason]              VARCHAR (256) NULL,
    [SpecialInstructions] VARCHAR (512) NULL,
    [CreatedByUserID]     VARCHAR (50)  CONSTRAINT [DF__Log_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]         DATETIME      CONSTRAINT [DF__Log_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID]    VARCHAR (50)  CONSTRAINT [DF__Log_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]        DATETIME      CONSTRAINT [DF__Log_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED ([ID] ASC)
);

