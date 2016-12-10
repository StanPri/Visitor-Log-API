CREATE TABLE [dbo].[VisitLocation] (
    [VisitID]    INT NOT NULL,
    [VisitorID]  INT NOT NULL,
    [LocationID] INT NOT NULL,
    CONSTRAINT [PK_VisitRoom] PRIMARY KEY CLUSTERED ([VisitID] ASC, [VisitorID] ASC, [LocationID] ASC),
    CONSTRAINT [FK_VisitRoom_Room] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID]),
    CONSTRAINT [FK_VisitRoom_Visit] FOREIGN KEY ([VisitID]) REFERENCES [dbo].[Visit] ([ID]),
    CONSTRAINT [FK_VisitVisitorLocation_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);

