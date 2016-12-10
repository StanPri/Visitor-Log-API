CREATE TABLE [dbo].[VisitHistory] (
    [ID]      INT IDENTITY (1, 1) NOT NULL,
    [VisitID] INT NOT NULL,
    CONSTRAINT [PK_VisitHistory] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_VisitHistory_Visit] FOREIGN KEY ([VisitID]) REFERENCES [dbo].[Visit] ([ID])
);

