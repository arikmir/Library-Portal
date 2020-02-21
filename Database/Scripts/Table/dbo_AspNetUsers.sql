--<< FileName: dbo_AspNetUsers.sql >>--
--<< TABLE: dbo.AspNetUsers >>--

--<< TABLE DEFINITION >>--

IF OBJECT_ID(N'dbo.AspNetUsers', N'U') IS NULL
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

--<< ADD CLOLUMNS >>--

--<< Sample >>--
/*IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE object_id = OBJECT_ID(N'dbo.AspNetUsers', N'U') AND
				[name] = 'ColumnName')
BEGIN
    ALTER TABLE dbo.AspNetUsers ADD ColumnName DataType Nullable
END
GO*/

--<< ALTER COLUMNS >>--

--<< PRIMARYKEY DEFINITION >>--

IF OBJECT_ID(N'dbo.PK_dbo.AspNetUsers', N'PK') IS NULL
SET ANSI_PADDING ON

ALTER TABLE [dbo].[AspNetUsers] ADD  CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) ON [PRIMARY]
GO

--<< DEFAULTS/CHECKS DEFINITION >>--

--<< INDEXES DEFINITION >>--

IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE name = 'UserNameIndex' AND object_id = OBJECT_ID(N'dbo.AspNetUsers', N'U'))
SET ANSI_PADDING ON

CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
) ON [PRIMARY]
GO

--<< FOREIGNKEYS DEFINITION >>--


--<< DROP OBJECTS >>--
