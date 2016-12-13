CREATE TABLE [dbo].[VisitVisitorHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [VisitID]          INT          NOT NULL,
    [VisitorID]        INT          NOT NULL,
    [ContactUserID]    VARCHAR (50) NOT NULL,
    [LocationID]       INT          NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_VisitVisitorHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);

