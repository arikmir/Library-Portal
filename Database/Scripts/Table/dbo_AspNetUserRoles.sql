--<< FileName: dbo_AspNetUserRoles.sql >>--
--<< TABLE: dbo.AspNetUserRoles >>--

--<< TABLE DEFINITION >>--

IF OBJECT_ID(N'dbo.AspNetUserRoles', N'U') IS NULL
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL
) ON [PRIMARY]

GO

--<< ADD CLOLUMNS >>--

--<< Sample >>--
/*IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE object_id = OBJECT_ID(N'dbo.AspNetUserRoles', N'U') AND
				[name] = 'ColumnName')
BEGIN
    ALTER TABLE dbo.AspNetUserRoles ADD ColumnName DataType Nullable
END
GO*/

--<< ALTER COLUMNS >>--

--<< PRIMARYKEY DEFINITION >>--

IF OBJECT_ID(N'dbo.PK_dbo.AspNetUserRoles', N'PK') IS NULL
SET ANSI_PADDING ON

ALTER TABLE [dbo].[AspNetUserRoles] ADD  CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
) ON [PRIMARY]
GO

--<< DEFAULTS/CHECKS DEFINITION >>--

--<< INDEXES DEFINITION >>--

IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE name = 'IX_RoleId' AND object_id = OBJECT_ID(N'dbo.AspNetUserRoles', N'U'))
SET ANSI_PADDING ON

CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
) ON [PRIMARY]
GO

IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE name = 'IX_UserId' AND object_id = OBJECT_ID(N'dbo.AspNetUserRoles', N'U'))
SET ANSI_PADDING ON

CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
) ON [PRIMARY]
GO

--<< FOREIGNKEYS DEFINITION >>--

IF OBJECT_ID(N'dbo.FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId', N'F') IS NULL
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
IF OBJECT_ID(N'dbo.FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId', N'F') IS NULL
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO

--<< DROP OBJECTS >>--
