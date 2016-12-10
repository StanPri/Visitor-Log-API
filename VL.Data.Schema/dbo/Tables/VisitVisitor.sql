CREATE TABLE [dbo].[VisitVisitor] (
    [VisitID]           INT        IDENTITY (1, 1) NOT NULL,
    [VisitorID]         INT        NOT NULL,
    [ComingToSeeUserID] INT        NOT NULL,
    [ts]                ROWVERSION NOT NULL,
    CONSTRAINT [PK_VisitVisitor] PRIMARY KEY CLUSTERED ([VisitID] ASC, [VisitorID] ASC, [ComingToSeeUserID] ASC),
    CONSTRAINT [FK_VisitLog_Visit] FOREIGN KEY ([VisitID]) REFERENCES [dbo].[Visit] ([ID]),
    CONSTRAINT [FK_VisitLog_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);

