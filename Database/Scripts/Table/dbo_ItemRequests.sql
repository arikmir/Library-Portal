--<< FileName: dbo_ItemRequests.sql >>--
--<< TABLE: dbo.ItemRequests >>--

--<< TABLE DEFINITION >>--

IF OBJECT_ID(N'dbo.ItemRequests', N'U') IS NULL
CREATE TABLE [dbo].[ItemRequests](
	[RequestId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[RequestUserId] [nvarchar](128) NOT NULL,
	[RequestedDate] [datetime2](7) NOT NULL
) ON [PRIMARY]

GO

--<< ADD CLOLUMNS >>--

--<< Sample >>--
/*IF NOT EXISTS (SELECT 1 FROM SYS.COLUMNS WHERE object_id = OBJECT_ID(N'dbo.ItemRequests', N'U') AND
				[name] = 'ColumnName')
BEGIN
    ALTER TABLE dbo.ItemRequests ADD ColumnName DataType Nullable
END
GO*/

--<< ALTER COLUMNS >>--

--<< PRIMARYKEY DEFINITION >>--

IF OBJECT_ID(N'dbo.PK_ItemRequests', N'PK') IS NULL
ALTER TABLE [dbo].[ItemRequests] ADD  CONSTRAINT [PK_ItemRequests] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC
) ON [PRIMARY]
GO

--<< DEFAULTS/CHECKS DEFINITION >>--

--<< INDEXES DEFINITION >>--

--<< FOREIGNKEYS DEFINITION >>--


--<< DROP OBJECTS >>--
