CREATE TABLE [dbo].[UserRole] (
    [UserID] INT        NOT NULL,
    [RoleID] INT        NOT NULL,
    [ts]     ROWVERSION NOT NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED ([UserID] ASC, [RoleID] ASC),
    CONSTRAINT [FK_UserRole_Role] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Role] ([ID])
);

