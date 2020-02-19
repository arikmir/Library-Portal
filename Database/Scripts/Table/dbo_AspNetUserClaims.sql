--<< FileName: dbo_AspNetUserClaims.sql >>--
--<< TABLE: dbo.AspNetUserClaims >>--

--<< TABLE DEFINITION >>--

IF OBJECT_ID(N'dbo.AspNetUserClaims', N'U') IS NULL
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

--<< ADD CLOLUMNS >>--

--<< Sample >>--
/*IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE object_id = OBJECT_ID(N'dbo.AspNetUserClaims', N'U') AND
				[name] = 'ColumnName')
BEGIN
    ALTER TABLE dbo.AspNetUserClaims ADD ColumnName DataType Nullable
END
GO*/

--<< ALTER COLUMNS >>--

--<< PRIMARYKEY DEFINITION >>--

IF OBJECT_ID(N'dbo.PK_dbo.AspNetUserClaims', N'PK') IS NULL
ALTER TABLE [dbo].[AspNetUserClaims] ADD  CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) ON [PRIMARY]
GO

--<< DEFAULTS/CHECKS DEFINITION >>--

--<< INDEXES DEFINITION >>--

IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE name = 'IX_UserId' AND object_id = OBJECT_ID(N'dbo.AspNetUserClaims', N'U'))
SET ANSI_PADDING ON

CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
) ON [PRIMARY]
GO

--<< FOREIGNKEYS DEFINITION >>--

IF OBJECT_ID(N'dbo.FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId', N'F') IS NULL
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO

--<< DROP OBJECTS >>--
