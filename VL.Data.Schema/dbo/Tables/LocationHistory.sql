CREATE TABLE [dbo].[LocationHistory] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [LocationID]       INT          NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_LocationHistory] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_LocationHistory_Location] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID])
);



