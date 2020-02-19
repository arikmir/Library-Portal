--<< FileName: dbo_AspNetRoles.sql >>--
--<< TABLE: dbo.AspNetRoles >>--

--<< TABLE DEFINITION >>--

IF OBJECT_ID(N'dbo.AspNetRoles', N'U') IS NULL
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL
) ON [PRIMARY]

GO

--<< ADD CLOLUMNS >>--

--<< Sample >>--
/*IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE object_id = OBJECT_ID(N'dbo.AspNetRoles', N'U') AND
				[name] = 'ColumnName')
BEGIN
    ALTER TABLE dbo.AspNetRoles ADD ColumnName DataType Nullable
END
GO*/

--<< ALTER COLUMNS >>--

--<< PRIMARYKEY DEFINITION >>--

IF OBJECT_ID(N'dbo.PK_dbo.AspNetRoles', N'PK') IS NULL
SET ANSI_PADDING ON

ALTER TABLE [dbo].[AspNetRoles] ADD  CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) ON [PRIMARY]
GO

--<< DEFAULTS/CHECKS DEFINITION >>--

--<< INDEXES DEFINITION >>--

IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE name = 'RoleNameIndex' AND object_id = OBJECT_ID(N'dbo.AspNetRoles', N'U'))
SET ANSI_PADDING ON

CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
) ON [PRIMARY]
GO

--<< FOREIGNKEYS DEFINITION >>--


--<< DROP OBJECTS >>--
