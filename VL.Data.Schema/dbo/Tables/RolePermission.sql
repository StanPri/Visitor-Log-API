CREATE TABLE [dbo].[RolePermission] (
    [RoleID]       INT        NOT NULL,
    [PermissionID] INT        NOT NULL,
    [ts]           ROWVERSION NOT NULL,
    CONSTRAINT [PK_RolePermission] PRIMARY KEY CLUSTERED ([RoleID] ASC, [PermissionID] ASC),
    CONSTRAINT [FK_RolePermission_Permission] FOREIGN KEY ([PermissionID]) REFERENCES [dbo].[Permission] ([ID]),
    CONSTRAINT [FK_RolePermission_Role] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Role] ([ID])
);

