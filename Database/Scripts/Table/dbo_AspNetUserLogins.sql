--<< FileName: dbo_AspNetUserLogins.sql >>--
--<< TABLE: dbo.AspNetUserLogins >>--

--<< TABLE DEFINITION >>--

IF OBJECT_ID(N'dbo.AspNetUserLogins', N'U') IS NULL
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL
) ON [PRIMARY]

GO

--<< ADD CLOLUMNS >>--

--<< Sample >>--
/*IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE object_id = OBJECT_ID(N'dbo.AspNetUserLogins', N'U') AND
				[name] = 'ColumnName')
BEGIN
    ALTER TABLE dbo.AspNetUserLogins ADD ColumnName DataType Nullable
END
GO*/

--<< ALTER COLUMNS >>--

--<< PRIMARYKEY DEFINITION >>--

IF OBJECT_ID(N'dbo.PK_dbo.AspNetUserLogins', N'PK') IS NULL
SET ANSI_PADDING ON

ALTER TABLE [dbo].[AspNetUserLogins] ADD  CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
) ON [PRIMARY]
GO

--<< DEFAULTS/CHECKS DEFINITION >>--

--<< INDEXES DEFINITION >>--

IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE name = 'IX_UserId' AND object_id = OBJECT_ID(N'dbo.AspNetUserLogins', N'U'))
SET ANSI_PADDING ON

CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
) ON [PRIMARY]
GO

--<< FOREIGNKEYS DEFINITION >>--

IF OBJECT_ID(N'dbo.FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId', N'F') IS NULL
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO

--<< DROP OBJECTS >>--
