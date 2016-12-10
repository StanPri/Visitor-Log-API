CREATE TABLE [dbo].[CampusHistory] (
    [ID]               INT           IDENTITY (1, 1) NOT NULL,
    [CampusID]         INT           NOT NULL,
    [Code]             VARCHAR (10)  NOT NULL,
    [Name]             VARCHAR (50)  NOT NULL,
    [Address]          VARCHAR (128) NOT NULL,
    [Address2]         VARCHAR (128) NULL,
    [City]             VARCHAR (50)  NULL,
    [ZipCode]          VARCHAR (10)  NULL,
    [IsActive]         BIT           NOT NULL,
    [ModifiedByUserID] VARCHAR (50)  NOT NULL,
    [ModifiedDate]     DATETIME      NOT NULL,
    [AuditDate]        DATETIME      NOT NULL,
    CONSTRAINT [PK_CampusHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);

