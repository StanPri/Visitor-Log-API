CREATE TABLE [dbo].[VisitorCompany] (
    [VisitorID]        INT          NOT NULL,
    [CompanyID]        INT          NOT NULL,
    [CreatedByUserID]  VARCHAR (50) NOT NULL,
    [CreatedDate]      DATETIME     NOT NULL,
    [ModifiedByUserID] VARCHAR (50) NOT NULL,
    [ModifiedDate]     DATETIME     NOT NULL,
    CONSTRAINT [PK_VisitorCompany] PRIMARY KEY CLUSTERED ([VisitorID] ASC, [CompanyID] ASC),
    CONSTRAINT [FK_VisitorCompany_Company] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Company] ([ID]),
    CONSTRAINT [FK_VisitorCompany_Visitor] FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);

