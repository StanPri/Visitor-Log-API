CREATE TABLE [dbo].[StationHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [StationID]        INT          NOT NULL,
    [Code]             VARCHAR (50) NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [IsActive]         BIT          NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_StationHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);

