--<< FileName: StaticData_dbo_Items.sql >>--
--<< STATIC_DATA [dbo].[Items] >>--

SET IDENTITY_INSERT [dbo].[Items] ON
IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 1))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (1, 'Kite Runner', 'Khaled Hoesseini', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 2))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (2, 'Freedom', 'Osho', 'Non-Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 3))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (3, '1984', 'H.G Wells', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 4))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (4, 'Ego Is The Enemy', 'Ryan Holiday', 'Non-Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 5))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (5, 'The Stranger', 'Albert Camus', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 6))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (6, 'Metamorphosis', 'Franz Kafka', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 7))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (7, 'The Alchemist', 'Paulo Coelho', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 8))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (8, 'Crime And Punishment', 'Fyodor Dostoevsky', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 9))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (9, 'Fight Club', 'Chuck Palahniuk', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 10))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (10, '48 Laws Of Power', 'Robert Greene', 'Non-Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 11))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (11, 'The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 12))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (12, 'Obstacle Is The Enemy', 'Ryan Holiday', 'Non-Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 13))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (13, 'Blink', 'Malcolm Gladwell', 'Non-Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 14))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (14, 'Moon Runner', 'Ali Hoesseini', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 15))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (15, 'Brave New World', 'Aldous Huxley', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 17))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (17, 'Animal Farm', 'George Orwell', 'Fiction')

IF NOT EXISTS(SELECT 1 FROM [dbo].[Items] WHERE ([ItemId] = 18))
	INSERT [dbo].[Items] ([ItemId], [ItemName], [Author], [ItemType]) VALUES (18, 'The Plague', 'Albert Camus', 'Fiction')

SET IDENTITY_INSERT [dbo].[Items] OFF
