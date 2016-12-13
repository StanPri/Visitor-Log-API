CREATE TABLE [dbo].[Visitor] (
    [ID]                 INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]          VARCHAR (128) NOT NULL,
    [LastName]           VARCHAR (128) NOT NULL,
    [CreatedByUserID]    INT           NOT NULL,
    [PersonIDCardNumber] VARCHAR (50)  NULL,
    CONSTRAINT [PK_Visitor] PRIMARY KEY CLUSTERED ([ID] ASC)
);



