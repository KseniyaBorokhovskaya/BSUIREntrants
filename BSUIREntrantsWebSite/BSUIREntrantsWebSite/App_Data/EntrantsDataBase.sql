USE [BSUIREntrantsDataBase]
GO
/****** Object:  Table [dbo].[Enrollees]    Script Date: 29.12.2017 23:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[HomeTown] [nvarchar](max) NULL,
	[TotalScore] [int] NOT NULL,
	[BirthDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Enrollees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Enrollees] ON 

INSERT [dbo].[Enrollees] ([ID], [LastName], [FirstName], [HomeTown], [TotalScore], [BirthDate]) VALUES (1, N'Borokhovskaya', N'Kseniya', N'Volozhin', 383, CAST(0x00008DD500000000 AS DateTime))
INSERT [dbo].[Enrollees] ([ID], [LastName], [FirstName], [HomeTown], [TotalScore], [BirthDate]) VALUES (2, N'Gurinovich', N'Daria', N'Soligorsk', 380, CAST(0x00008E3100000000 AS DateTime))
INSERT [dbo].[Enrollees] ([ID], [LastName], [FirstName], [HomeTown], [TotalScore], [BirthDate]) VALUES (3, N'Belyasova', N'Angelina', N'Bovruysk', 400, CAST(0x00008E9000000000 AS DateTime))
INSERT [dbo].[Enrollees] ([ID], [LastName], [FirstName], [HomeTown], [TotalScore], [BirthDate]) VALUES (5, N'ljhlj', N'lj', N'jbjb', 334, CAST(0x00008D4A00000000 AS DateTime))
INSERT [dbo].[Enrollees] ([ID], [LastName], [FirstName], [HomeTown], [TotalScore], [BirthDate]) VALUES (6, N'dskhvg', N'hkg', N'lshklv', 12, CAST(0x00008DBB00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Enrollees] OFF
