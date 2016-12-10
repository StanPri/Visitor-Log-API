CREATE TABLE [dbo].[LogVisit] (
    [LogID]     INT NOT NULL,
    [VisitorID] INT NOT NULL,
    [VisitID]   INT NOT NULL,
    CONSTRAINT [PK_VisitorLog] PRIMARY KEY CLUSTERED ([LogID] ASC, [VisitorID] ASC, [VisitID] ASC),
    CONSTRAINT [FK_LogVisit_Visit] FOREIGN KEY ([VisitID]) REFERENCES [dbo].[Visit] ([ID]),
    CONSTRAINT [FK_VisitorLog_Log] FOREIGN KEY ([LogID]) REFERENCES [dbo].[Log] ([ID]),
    CONSTRAINT [FK_VisitorLog_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);

