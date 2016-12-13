CREATE TABLE [dbo].[LogVisitor] (
    [LogID]            INT      NOT NULL,
    [VisitorID]        INT      NOT NULL,
    [ContactID]        INT      NOT NULL,
    [LocationID]       INT      NOT NULL,
    [CreatedByUserID]  INT      NOT NULL,
    [CreatedDate]      DATETIME CONSTRAINT [DF_LogVisit_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserID] INT      NOT NULL,
    [ModifiedDate]     DATETIME NOT NULL,
    CONSTRAINT [PK_LogVisit_1] PRIMARY KEY CLUSTERED ([LogID] ASC, [VisitorID] ASC, [ContactID] ASC, [LocationID] ASC),
    CONSTRAINT [FK_LogVisit_Contact] FOREIGN KEY ([ContactID]) REFERENCES [dbo].[Contact] ([ID]),
    CONSTRAINT [FK_LogVisitor_Location] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID]),
    CONSTRAINT [FK_LogVisitor_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID]),
    CONSTRAINT [FK_VisitorLog_Log] FOREIGN KEY ([LogID]) REFERENCES [dbo].[Log] ([ID])
);

