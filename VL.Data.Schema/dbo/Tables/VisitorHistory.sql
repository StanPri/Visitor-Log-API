CREATE TABLE [dbo].[VisitorHistory] (
    [ID]        INT IDENTITY (1, 1) NOT NULL,
    [VisitorID] INT NOT NULL,
    CONSTRAINT [PK_VisitorAudit] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_VisitorHistory_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);

