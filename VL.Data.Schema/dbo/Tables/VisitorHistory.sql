CREATE TABLE [dbo].[VisitorHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [VisitorID]        INT          NOT NULL,
    [FirstName]        VARCHAR (50) NOT NULL,
    [LastName]         VARCHAR (50) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_VisitorAudit] PRIMARY KEY CLUSTERED ([ID] ASC)
);



