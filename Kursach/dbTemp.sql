USE [master]
GO
/****** Object:  Database [Restraunt_db_temp]    Script Date: 13.04.2021 0:15:03 ******/
CREATE DATABASE [Restraunt_db_temp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restraunt_db_temp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Restraunt_db_temp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Restraunt_db_temp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Restraunt_db_temp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Restraunt_db_temp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restraunt_db_temp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restraunt_db_temp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restraunt_db_temp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restraunt_db_temp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Restraunt_db_temp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restraunt_db_temp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Restraunt_db_temp] SET  MULTI_USER 
GO
ALTER DATABASE [Restraunt_db_temp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Restraunt_db_temp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restraunt_db_temp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restraunt_db_temp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Restraunt_db_temp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Restraunt_db_temp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Restraunt_db_temp] SET QUERY_STORE = OFF
GO
USE [Restraunt_db_temp]
GO
/****** Object:  Table [dbo].[Dishes]    Script Date: 13.04.2021 0:15:03 ******/
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
	[Recipe] [nvarchar](max) NULL,
 CONSTRAINT [PK_Dishes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dishes_Type]    Script Date: 13.04.2021 0:15:03 ******/
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
/****** Object:  View [dbo].[v_Dishes_With_Types_View]    Script Date: 13.04.2021 0:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[v_Dishes_With_Types_View] as
select Dishes.id, Dishes.Name, Dishes.Price, Dishes_Type.Name as Type, Dishes.Weight, Dishes.PicturePath from Dishes
join Dishes_Type on Dishes_Type.id = Dishes.id_Dishes_Type
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 13.04.2021 0:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Time] [datetime] NOT NULL,
	[dish_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[IsOrdered] [bit] NOT NULL,
	[IsCooking] [bit] NOT NULL,
	[IsCooked] [bit] NOT NULL,
	[IsDelivered] [bit] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_orders_view]    Script Date: 13.04.2021 0:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_orders_view]
AS
SELECT        dbo.Dishes.PicturePath, dbo.Dishes.Name, dbo.Orders.Time, dbo.Orders.IsOrdered, dbo.Orders.IsCooking, dbo.Orders.IsCooked, dbo.Orders.IsDelivered, dbo.Orders.id
FROM            dbo.Orders INNER JOIN
                         dbo.Dishes ON dbo.Orders.dish_id = dbo.Dishes.id
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13.04.2021 0:15:03 ******/
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
	[Mailing] [bit] NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_Cards]    Script Date: 13.04.2021 0:15:03 ******/
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
/****** Object:  Table [dbo].[Users_Types]    Script Date: 13.04.2021 0:15:03 ******/
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
/****** Object:  Table [dbo].[UsersAndCards]    Script Date: 13.04.2021 0:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersAndCards](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[User] [int] NOT NULL,
	[Card] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_UsersAndCards] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Dishes] ON 

INSERT [dbo].[Dishes] ([id], [Name], [Price], [id_Dishes_Type], [Weight], [PicturePath], [Recipe]) VALUES (1, N'Греко-восточный', 520.0000, 1, 380, N'/pictures/dishes/grekovostochniy.jpg', NULL)
INSERT [dbo].[Dishes] ([id], [Name], [Price], [id_Dishes_Type], [Weight], [PicturePath], [Recipe]) VALUES (2, N'Цезарь с куринной грудкой', 580.0000, 1, 240, N'/pictures/dishes/cesarskutsoi.jpg', NULL)
INSERT [dbo].[Dishes] ([id], [Name], [Price], [id_Dishes_Type], [Weight], [PicturePath], [Recipe]) VALUES (3, N'Хумус с горячей лепешкой', 560.0000, 2, 320, N'/pictures/dishes/humusslepewkoi.jpg', NULL)
INSERT [dbo].[Dishes] ([id], [Name], [Price], [id_Dishes_Type], [Weight], [PicturePath], [Recipe]) VALUES (4, N'Тар-тар', 340.0000, 2, 260, N'/pictures/dishes/tartar.jpg', NULL)
SET IDENTITY_INSERT [dbo].[Dishes] OFF
GO
SET IDENTITY_INSERT [dbo].[Dishes_Type] ON 

INSERT [dbo].[Dishes_Type] ([id], [Name]) VALUES (1, N'Салаты')
INSERT [dbo].[Dishes_Type] ([id], [Name]) VALUES (2, N'Закуски')
SET IDENTITY_INSERT [dbo].[Dishes_Type] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([id], [Time], [dish_id], [user_id], [IsOrdered], [IsCooking], [IsCooked], [IsDelivered]) VALUES (9, CAST(N'2021-04-09T16:41:13.947' AS DateTime), 1, 2, 0, 0, 0, 0)
INSERT [dbo].[Orders] ([id], [Time], [dish_id], [user_id], [IsOrdered], [IsCooking], [IsCooked], [IsDelivered]) VALUES (10, CAST(N'2021-04-10T12:37:57.050' AS DateTime), 1, 2, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [Type], [Telephone], [BirthDate], [RegDate], [Email], [Name], [Sorename], [Thirdname], [Mailing], [Password]) VALUES (2, 1, N'+7(900)900-00-00', CAST(N'1999-01-01' AS Date), CAST(N'2020-01-01' AS Date), N'shda@mail.ru', N'Шабалкин', N'Данила', N'Алексеевич', 0, N'1234')
INSERT [dbo].[Users] ([id], [Type], [Telephone], [BirthDate], [RegDate], [Email], [Name], [Sorename], [Thirdname], [Mailing], [Password]) VALUES (3, 1, N'+7(999)999-99-99', CAST(N'1998-04-05' AS Date), CAST(N'2021-04-13' AS Date), N'a@mail.ru', N'a', N'f', N'g', 1, N'1234')
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
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Dishes] FOREIGN KEY([dish_id])
REFERENCES [dbo].[Dishes] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Dishes]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users_Types] FOREIGN KEY([Type])
REFERENCES [dbo].[Users_Types] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users_Types]
GO
ALTER TABLE [dbo].[UsersAndCards]  WITH CHECK ADD  CONSTRAINT [FK_UsersAndCards_Users] FOREIGN KEY([User])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UsersAndCards] CHECK CONSTRAINT [FK_UsersAndCards_Users]
GO
ALTER TABLE [dbo].[UsersAndCards]  WITH CHECK ADD  CONSTRAINT [FK_UsersAndCards_Users_Cards] FOREIGN KEY([Card])
REFERENCES [dbo].[Users_Cards] ([Number])
GO
ALTER TABLE [dbo].[UsersAndCards] CHECK CONSTRAINT [FK_UsersAndCards_Users_Cards]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Orders"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Dishes"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_orders_view'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_orders_view'
GO
USE [master]
GO
ALTER DATABASE [Restraunt_db_temp] SET  READ_WRITE 
GO
