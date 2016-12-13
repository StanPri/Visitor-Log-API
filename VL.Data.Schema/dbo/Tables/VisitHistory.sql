CREATE TABLE [dbo].[VisitHistory] (
    [ID]                    INT          IDENTITY (1, 1) NOT NULL,
    [VisitID]               INT          NOT NULL,
    [ScheduledCheckInTime]  DATETIME     NOT NULL,
    [ScheduledCheckOutTime] DATETIME     NOT NULL,
    [ActualCheckInTime]     DATETIME     NULL,
    [ActualCheckOutTime]    DATETIME     NULL,
    [ModifiedByUserID]      VARCHAR (50) NOT NULL,
    [ModifiedDate]          VARCHAR (50) NOT NULL,
    [AuditDate]             DATETIME     NOT NULL,
    CONSTRAINT [PK_VisitHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);



