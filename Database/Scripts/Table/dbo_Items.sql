--<< FileName: dbo_Items.sql >>--
--<< TABLE: dbo.Items >>--

--<< TABLE DEFINITION >>--

IF OBJECT_ID(N'dbo.Items', N'U') IS NULL
CREATE TABLE [dbo].[Items](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[Author] [varchar](50) NULL,
	[ItemType] [varchar](50) NULL
) ON [PRIMARY]

GO

--<< ADD CLOLUMNS >>--

--<< Sample >>--
/*IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE object_id = OBJECT_ID(N'dbo.Items', N'U') AND
				[name] = 'ColumnName')
BEGIN
    ALTER TABLE dbo.Items ADD ColumnName DataType Nullable
END
GO*/

--<< ALTER COLUMNS >>--

--<< PRIMARYKEY DEFINITION >>--

IF OBJECT_ID(N'dbo.PK_Items', N'PK') IS NULL
ALTER TABLE [dbo].[Items] ADD  CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
) ON [PRIMARY]
GO

--<< DEFAULTS/CHECKS DEFINITION >>--

IF OBJECT_ID(N'dbo.DF_Items_Author', N'D') IS NULL
ALTER TABLE [dbo].[Items] ADD  CONSTRAINT [DF_Items_Author]  DEFAULT ('') FOR [Author]
GO

--<< INDEXES DEFINITION >>--

--<< FOREIGNKEYS DEFINITION >>--


--<< DROP OBJECTS >>--
