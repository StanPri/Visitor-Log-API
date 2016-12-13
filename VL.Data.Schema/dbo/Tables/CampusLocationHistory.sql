CREATE TABLE [dbo].[CampusLocationHistory] (
    [ID]               INT          NOT NULL,
    [CampusID]         INT          NOT NULL,
    [LocationID]       INT          NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    [AuditDate]        DATETIME     NOT NULL,
    CONSTRAINT [PK_CampusLocationHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);



