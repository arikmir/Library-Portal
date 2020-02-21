--<< FileName: StaticData_dbo_AspNetRoles.sql >>--
--<< STATIC_DATA [dbo].[AspNetRoles] >>--

IF NOT EXISTS(SELECT 1 FROM [dbo].[AspNetRoles] WHERE ([Id] = N'4edcee5b-b372-4c3d-be5e-7b516ee8ab7e'))
	INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4edcee5b-b372-4c3d-be5e-7b516ee8ab7e', N'Administrator')

IF NOT EXISTS(SELECT 1 FROM [dbo].[AspNetRoles] WHERE ([Id] = N'a93f611a-0037-4211-9cc0-037bdcc8d9ff'))
	INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a93f611a-0037-4211-9cc0-037bdcc8d9ff', N'Librarian')

IF NOT EXISTS(SELECT 1 FROM [dbo].[AspNetRoles] WHERE ([Id] = N'a530072f-7f7c-413e-a68e-c2e1394f1138'))
	INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a530072f-7f7c-413e-a68e-c2e1394f1138', N'Student')

