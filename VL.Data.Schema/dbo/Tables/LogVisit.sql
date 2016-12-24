CREATE TABLE [dbo].[LogVisit] (
    [LogID]            INT          NOT NULL,
    [VisitID]          INT          NOT NULL,
    [VisitorID]        INT          NOT NULL,
    [BadgeID]          INT          NOT NULL,
    [AssetID]          INT          NOT NULL,
    [CreatedByUserID]  VARCHAR (50) CONSTRAINT [DF_LogVisit_CreatedByUserID] DEFAULT ('_admin') NOT NULL,
    [CreatedDate]      DATETIME     CONSTRAINT [DF_LogVisit_CreatedDate_1] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) CONSTRAINT [DF_LogVisit_ModifiedByUserID] DEFAULT ('_admin') NOT NULL,
    [ModifiedDate]     DATETIME     CONSTRAINT [DF_LogVisit_ModifiedDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_LogVisit] PRIMARY KEY CLUSTERED ([LogID] ASC, [VisitID] ASC, [VisitorID] ASC, [BadgeID] ASC, [AssetID] ASC),
    CONSTRAINT [FK_LogVisit_Asset] FOREIGN KEY ([AssetID]) REFERENCES [dbo].[Asset] ([ID]),
    CONSTRAINT [FK_LogVisit_Badge] FOREIGN KEY ([BadgeID]) REFERENCES [dbo].[Badge] ([ID]),
    CONSTRAINT [FK_LogVisit_Log] FOREIGN KEY ([LogID]) REFERENCES [dbo].[Log] ([ID]),
    CONSTRAINT [FK_LogVisit_Visit] FOREIGN KEY ([VisitID]) REFERENCES [dbo].[Visit] ([ID]),
    CONSTRAINT [FK_LogVisit_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);



