CREATE TABLE [dbo].[Visit] (
    [ID]                    INT          IDENTITY (1, 1) NOT NULL,
    [ScheduledCheckInTime]  DATETIME     NOT NULL,
    [ScheduledCheckOutTime] DATETIME     NOT NULL,
    [ActualCheckInTime]     DATETIME     NULL,
    [ActualCheckOutTime]    DATETIME     NULL,
    [CreatedByUserID]       VARCHAR (50) CONSTRAINT [DF_Visit_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]           DATETIME     CONSTRAINT [DF_Visit_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID]      VARCHAR (50) CONSTRAINT [DF_Visit_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]          DATETIME     CONSTRAINT [DF_Visit_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED ([ID] ASC)
);



