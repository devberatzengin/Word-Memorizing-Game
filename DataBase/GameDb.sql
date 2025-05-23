USE [GameDb]
GO
/****** Object:  Table [dbo].[tblExamHistory]    Script Date: 20.05.2025 17:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblExamHistory](
	[HistoryID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[WordID] [int] NULL,
	[AnswerDate] [date] NULL,
	[IsCorrect] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 20.05.2025 17:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [int] NOT NULL,
	[UserName] [nvarchar](15) NOT NULL,
	[UserPassword] [nchar](20) NOT NULL,
	[UserType] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblWordProgress]    Script Date: 20.05.2025 17:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblWordProgress](
	[ProgressID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[WordID] [int] NOT NULL,
	[CorrectCount] [int] NULL,
	[LastCorrectDate] [date] NULL,
	[NextTestDate] [date] NULL,
	[IsLearned] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProgressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblWords]    Script Date: 20.05.2025 17:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblWords](
	[WordID] [int] NOT NULL,
	[EngWordName] [varchar](20) NULL,
	[TurWordName] [varchar](20) NULL,
	[Picture] [varchar](30) NULL,
	[WordLevel] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[WordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblWordSamples]    Script Date: 20.05.2025 17:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblWordSamples](
	[SampleID] [int] IDENTITY(1,1) NOT NULL,
	[WordID] [int] NOT NULL,
	[Samples] [nvarchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SampleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (1, N'Berat', N'1234                ', 1)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (2, N'Ahmet', N'1234                ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (3, N'Emin', N'0000                ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (4, N'Emine', N'123                 ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (5, N'Mehmet', N'123                 ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (6, N'Selçuk', N'12345               ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (7, N'Ege', N'dadas               ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (8, N'Mert', N'sifre               ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (9, N'Yiğit', N'das                 ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (10, N'Melisa', N'123                 ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (11, N'Cansu', N'567                 ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (12, N'Nergiz', N'999                 ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (13, N'Sude', N'555                 ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (14, N'Bengü', N'444                 ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (15, N'Murat', N'12345               ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (16, N'Ömer', N'sifre               ', 0)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (17, N'Gökdeniz', N'2222                ', NULL)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (18, N'Admin', N'Admin               ', NULL)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (19, N'Akif', N'5565                ', NULL)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (20, N'AhmetMehmet', N'4444                ', NULL)
INSERT [dbo].[tblUser] ([UserID], [UserName], [UserPassword], [UserType]) VALUES (21, N'Meryem', N'123456              ', NULL)
GO
SET IDENTITY_INSERT [dbo].[tblWordProgress] ON 

INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (1, 1, 2, 0, CAST(N'2025-04-24' AS Date), CAST(N'2025-10-21' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (2, 1, 11, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (3, 1, 7, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-07' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (4, 20, 15, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (5, 20, 6, 0, CAST(N'2025-04-24' AS Date), CAST(N'2025-04-25' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (6, 20, 3, 0, CAST(N'2025-04-24' AS Date), CAST(N'2025-04-25' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (7, 1, 8, 1, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-15' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (8, 1, 15, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (9, 1, 14, 1, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-15' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (10, 1, 10, 0, CAST(N'2025-04-24' AS Date), CAST(N'2025-05-24' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (11, 1, 9, 1, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-15' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (12, 1, 12, 0, CAST(N'2025-05-03' AS Date), CAST(N'2025-05-04' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (13, 1, 4, 1, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-15' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (14, 1, 5, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (15, 1, 3, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-07' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (16, 1, 13, 0, CAST(N'2025-04-24' AS Date), CAST(N'2026-04-24' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (17, 1, 1, 0, CAST(N'2025-04-24' AS Date), CAST(N'2025-07-23' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (18, 1, 6, 1, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-15' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (19, 1, 16, 1, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-15' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (20, 21, 15, 0, CAST(N'2025-04-24' AS Date), CAST(N'2025-04-25' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (21, 21, 1, 0, CAST(N'2025-04-24' AS Date), CAST(N'2025-04-25' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (22, 21, 11, 0, CAST(N'2025-04-24' AS Date), CAST(N'2025-04-25' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (23, 1, 19, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (24, 20, 11, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-07' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (25, 20, 1, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (26, 20, 4, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (27, 20, 10, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (28, 20, 8, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (29, 20, 19, 2, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-07' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (30, 20, 9, 1, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (31, 20, 16, 0, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (32, 20, 17, 1, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (33, 20, 12, 1, CAST(N'2025-04-30' AS Date), CAST(N'2025-05-01' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (34, 1, 18, 0, CAST(N'2025-05-03' AS Date), CAST(N'2025-05-04' AS Date), 0)
INSERT [dbo].[tblWordProgress] ([ProgressID], [UserID], [WordID], [CorrectCount], [LastCorrectDate], [NextTestDate], [IsLearned]) VALUES (35, 1, 20, 1, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-15' AS Date), 0)
SET IDENTITY_INSERT [dbo].[tblWordProgress] OFF
GO
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (1, N'Word', N'Kelime', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (2, N'School', N'Okul', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (3, N'Game', N'Oyun', N'C://words/test.jpg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (4, N'Computer', N'Bilgisayar', N'C://words/test.jpg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (5, N'Software', N'Yazılım', N'C://words/test.jpg', 3)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (6, N'Headphone', N'Kulaklık', N'C://words/test.jpg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (7, N'Water', N'Su', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (8, N'Table', N'Masa', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (9, N'Chair', N'Sandalye', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (10, N'Phone', N'Telefon', N'C://words/test.jpg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (11, N'Glass', N'Cam', N'C://words/test.jpg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (12, N'Door', N'Kapı', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (13, N'Cable', N'Kablo', N'C://words/test.jpg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (14, N'Floor', N'Zemin', N'C://words/test.jpg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (15, N'Case', N'Kasa', N'C://words/Case.jpeg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (16, N'Bus', N'Otobus', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (17, N'Wallet', N'Cüzdan', N'C://words/test.jpg', 2)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (18, N'Plane', N'Uçak', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (19, N'Suitcase', N'Bavul', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (20, N'Home', N'Ev', N'C://words/test.jpg', 1)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (21, N'Crime', N'Suç', N'C://words/test.jpg', 3)
INSERT [dbo].[tblWords] ([WordID], [EngWordName], [TurWordName], [Picture], [WordLevel]) VALUES (22, N'Coffee', N'Kahve', N'deneme', NULL)
GO
SET IDENTITY_INSERT [dbo].[tblWordSamples] ON 

INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (1, 1, N'I learned a new word today.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (2, 2, N'The school opens at 8 a.m.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (3, 3, N'They like to play a game after dinner.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (4, 4, N'My computer crashed during the exam.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (5, 5, N'She is studying software engineering.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (6, 6, N'He bought new headphones yesterday.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (7, 7, N'Drink more water to stay healthy.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (8, 8, N'There is a big table in the room.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (9, 9, N'She sat on the chair near the window.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (10, 10, N'I forgot my phone at home.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (11, 11, N'The glass is full of juice.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (12, 12, N'Please close the door.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (13, 13, N'The cable is too short for the charger.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (14, 14, N'I cleaned the floor this morning.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (15, 15, N'He keeps his tools in a case.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (16, 1, N'This word has many meanings.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (17, 1, N'Can you spell the word correctly?')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (18, 1, N'He used the word in a sentence.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (19, 2, N'My school is near the park.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (20, 2, N'She loves her new school.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (21, 2, N'School starts at 9 a.m.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (22, 3, N'They played a fun game.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (23, 3, N'This game is really exciting.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (24, 3, N'Do you want to join the game?')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (25, 4, N'The computer is not working.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (26, 4, N'I bought a new computer.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (27, 4, N'She is using the computer for homework.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (28, 5, N'He develops software for a living.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (29, 5, N'This software needs an update.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (30, 5, N'They designed a useful software tool.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (31, 6, N'These headphones are wireless.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (32, 6, N'She listens to music with headphones.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (33, 6, N'Headphones help you focus.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (34, 7, N'Drink a glass of water.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (35, 7, N'Water is essential for life.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (36, 7, N'He filled the bottle with water.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (37, 8, N'The table is made of wood.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (38, 8, N'She placed the vase on the table.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (39, 8, N'Let’s sit around the table.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (40, 9, N'He broke the chair.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (41, 9, N'The chair is very comfortable.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (42, 9, N'I sat on the chair near the door.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (43, 10, N'My phone is charging.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (44, 10, N'She called me on the phone.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (45, 10, N'Don’t forget your phone.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (46, 11, N'The glass broke into pieces.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (47, 11, N'He poured milk into the glass.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (48, 11, N'Clean the glass before using it.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (49, 12, N'Please open the door.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (50, 12, N'The door is locked.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (51, 12, N'She knocked on the door.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (52, 13, N'The cable is too short.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (53, 13, N'He lost the charging cable.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (54, 13, N'This cable is expensive.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (55, 14, N'The floor is wet.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (56, 14, N'She cleaned the floor.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (57, 14, N'We sat on the floor.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (58, 15, N'The case is made of leather.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (59, 15, N'He opened the case.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (60, 15, N'Put the tools in the case.')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (61, 18, N'Acun Ilıcalı bought a new plane')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (62, 19, N'I have a blueviolet suitcase from İtally')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (63, 20, N'We have nice home in the nyc')
INSERT [dbo].[tblWordSamples] ([SampleID], [WordID], [Samples]) VALUES (64, 22, N'Can ı get a double double extra large coffee pls')
SET IDENTITY_INSERT [dbo].[tblWordSamples] OFF
GO
/****** Object:  Index [UQ_UserWord]    Script Date: 20.05.2025 17:28:59 ******/
ALTER TABLE [dbo].[tblWordProgress] ADD  CONSTRAINT [UQ_UserWord] UNIQUE NONCLUSTERED 
(
	[UserID] ASC,
	[WordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblWordProgress] ADD  DEFAULT ((0)) FOR [CorrectCount]
GO
ALTER TABLE [dbo].[tblWordProgress] ADD  DEFAULT ((0)) FOR [IsLearned]
GO
ALTER TABLE [dbo].[tblExamHistory]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUser] ([UserID])
GO
ALTER TABLE [dbo].[tblExamHistory]  WITH CHECK ADD FOREIGN KEY([WordID])
REFERENCES [dbo].[tblWords] ([WordID])
GO
ALTER TABLE [dbo].[tblWordProgress]  WITH CHECK ADD  CONSTRAINT [FK_WordProgress_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUser] ([UserID])
GO
ALTER TABLE [dbo].[tblWordProgress] CHECK CONSTRAINT [FK_WordProgress_User]
GO
ALTER TABLE [dbo].[tblWordProgress]  WITH CHECK ADD  CONSTRAINT [FK_WordProgress_Word] FOREIGN KEY([WordID])
REFERENCES [dbo].[tblWords] ([WordID])
GO
ALTER TABLE [dbo].[tblWordProgress] CHECK CONSTRAINT [FK_WordProgress_Word]
GO
ALTER TABLE [dbo].[tblWordSamples]  WITH CHECK ADD FOREIGN KEY([WordID])
REFERENCES [dbo].[tblWords] ([WordID])
GO
