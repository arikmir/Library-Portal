--<< FileName: dbo_CheckedOutTable.sql >>--
--<< TABLE: dbo.CheckedOutTable >>--

--<< TABLE DEFINITION >>--

IF OBJECT_ID(N'dbo.CheckedOutTable', N'U') IS NULL
CREATE TABLE [dbo].[CheckedOutTable](
	[CheckedOutId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[CheckedOutDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
	[CheckedOutBy] [nvarchar](128) NOT NULL
) ON [PRIMARY]

GO

--<< ADD CLOLUMNS >>--

--<< Sample >>--
/*IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE object_id = OBJECT_ID(N'dbo.CheckedOutTable', N'U') AND
				[name] = 'ColumnName')
BEGIN
    ALTER TABLE dbo.CheckedOutTable ADD ColumnName DataType Nullable
END
GO*/

--<< ALTER COLUMNS >>--

--<< PRIMARYKEY DEFINITION >>--

IF OBJECT_ID(N'dbo.PK_CheckedoutTable', N'PK') IS NULL
ALTER TABLE [dbo].[CheckedOutTable] ADD  CONSTRAINT [PK_CheckedoutTable] PRIMARY KEY CLUSTERED 
(
	[CheckedOutId] ASC
) ON [PRIMARY]
GO

--<< DEFAULTS/CHECKS DEFINITION >>--

--<< INDEXES DEFINITION >>--

--<< FOREIGNKEYS DEFINITION >>--


--<< DROP OBJECTS >>--
