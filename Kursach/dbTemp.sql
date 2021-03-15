USE [Restraunt_DB_Temp]
GO
/****** Object:  Table [dbo].[Dishes]    Script Date: 15.03.2021 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dishes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[id_Dishes_Type] [int] NOT NULL,
	[Weight] [int] NOT NULL,
	[PicturePath] [nvarchar](max) NULL,
 CONSTRAINT [PK_Dishes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dishes_Type]    Script Date: 15.03.2021 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dishes_Type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Dishes_Type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15.03.2021 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [int] NOT NULL,
	[Telephone] [nvarchar](16) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[RegDate] [date] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Sorename] [nvarchar](50) NOT NULL,
	[Thirdname] [nvarchar](50) NOT NULL,
	[CardNumber] [nvarchar](16) NOT NULL,
	[Mailing] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_Cards]    Script Date: 15.03.2021 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Cards](
	[Number] [nvarchar](16) NOT NULL,
	[CVV/CVC] [nvarchar](3) NOT NULL,
 CONSTRAINT [PK_Users_Cards] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_Types]    Script Date: 15.03.2021 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users_Types] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Dishes] ON 

INSERT [dbo].[Dishes] ([id], [Name], [Price], [id_Dishes_Type], [Weight], [PicturePath]) VALUES (1, N'Греко-восточный', 520.0000, 1, 380, N'\Res\Static\Pictures\Dishes\grekovostochniy.png')
INSERT [dbo].[Dishes] ([id], [Name], [Price], [id_Dishes_Type], [Weight], [PicturePath]) VALUES (2, N'Цезарь с куринной грудкой', 580.0000, 1, 240, N'\Res\Static\Pictures\Dishes\grekovostochniy.png')
INSERT [dbo].[Dishes] ([id], [Name], [Price], [id_Dishes_Type], [Weight], [PicturePath]) VALUES (3, N'Хумус с горячей лепешкой', 560.0000, 2, 320, N'\Res\Static\Pictures\Dishes\grekovostochniy.png')
INSERT [dbo].[Dishes] ([id], [Name], [Price], [id_Dishes_Type], [Weight], [PicturePath]) VALUES (4, N'Тар-тар', 340.0000, 2, 260, N'\Res\Static\Pictures\Dishes\grekovostochniy.png')
SET IDENTITY_INSERT [dbo].[Dishes] OFF
GO
SET IDENTITY_INSERT [dbo].[Dishes_Type] ON 

INSERT [dbo].[Dishes_Type] ([id], [Name]) VALUES (1, N'Салаты')
INSERT [dbo].[Dishes_Type] ([id], [Name]) VALUES (2, N'Закуски')
SET IDENTITY_INSERT [dbo].[Dishes_Type] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [Type], [Telephone], [BirthDate], [RegDate], [Email], [Name], [Sorename], [Thirdname], [CardNumber], [Mailing]) VALUES (2, 1, N'+7(900)900-00-00', CAST(N'1999-01-01' AS Date), CAST(N'2020-01-01' AS Date), N'shda@mail.ru', N'Шабалкин', N'Данила', N'Алексеевич', N'1111111111111111', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
INSERT [dbo].[Users_Cards] ([Number], [CVV/CVC]) VALUES (N'1111111111111111', N'111')
GO
SET IDENTITY_INSERT [dbo].[Users_Types] ON 

INSERT [dbo].[Users_Types] ([id], [Name]) VALUES (1, N'Guest')
INSERT [dbo].[Users_Types] ([id], [Name]) VALUES (2, N'Administrator')
INSERT [dbo].[Users_Types] ([id], [Name]) VALUES (3, N'Cook')
INSERT [dbo].[Users_Types] ([id], [Name]) VALUES (4, N'Servant')
INSERT [dbo].[Users_Types] ([id], [Name]) VALUES (5, N'SAdministrator')
SET IDENTITY_INSERT [dbo].[Users_Types] OFF
GO
ALTER TABLE [dbo].[Dishes]  WITH CHECK ADD  CONSTRAINT [FK_Dishes_Dishes_Type] FOREIGN KEY([id_Dishes_Type])
REFERENCES [dbo].[Dishes_Type] ([id])
GO
ALTER TABLE [dbo].[Dishes] CHECK CONSTRAINT [FK_Dishes_Dishes_Type]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users_Cards] FOREIGN KEY([CardNumber])
REFERENCES [dbo].[Users_Cards] ([Number])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users_Cards]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users_Types] FOREIGN KEY([Type])
REFERENCES [dbo].[Users_Types] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users_Types]
GO
