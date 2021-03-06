USE [Restuarant]
GO
/****** Object:  Table [dbo].[CheckDetail]    Script Date: 2/16/2017 11:09:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[Total] [float] NULL,
	[CheckId] [int] NOT NULL,
	[Qty] [int] NOT NULL,
 CONSTRAINT [PK_CheckDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CheckSummary]    Script Date: 2/16/2017 11:09:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckSummary](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CheckNo] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_CheckSummary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Item]    Script Date: 2/16/2017 11:09:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Description] [varchar](250) NULL,
	[Category] [varchar](50) NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CheckDetail] ON 

INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (24, 1, N'Chiken Burger', 500, 12, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (25, 2, N'Tuna Sandwitch', 1500, 12, 2)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (26, 2, N'Tuna Sandwitch', 750, 13, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (27, 3, N'Club Sandwitch', 800, 13, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (28, 4, N'Coke,Lemanade', 200, 13, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (29, 5, N'CreamSoda', 600, 14, 3)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (30, 2, N'Tuna Sandwitch', 1500, 15, 2)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (31, 3, N'Club Sandwitch', 800, 15, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (32, 2, N'Tuna Sandwitch', 750, 16, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (33, 3, N'Club Sandwitch', 2400, 16, 3)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (34, 4, N'Coke,Lemanade', 200, 16, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (35, 1, N'Chiken Burger', 1500, 17, 3)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (36, 2, N'Tuna Sandwitch', 750, 18, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (37, 4, N'Coke,Lemanade', 200, 18, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (38, 3, N'Club Sandwitch', 1600, 18, 2)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (39, 4, N'Coke,Lemanade', 200, 19, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (40, 3, N'Club Sandwitch', 800, 19, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (41, 2, N'Tuna Sandwitch', 1500, 19, 2)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (42, 3, N'Club Sandwitch', 2400, 20, 3)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (43, 4, N'Coke,Lemanade', 400, 21, 2)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (44, 5, N'CreamSoda', 200, 21, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (45, 2, N'Tuna Sandwitch', 750, 22, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (46, 5, N'CreamSoda', 200, 22, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (47, 4, N'Coke,Lemanade', 400, 22, 2)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (48, 4, N'Coke,Lemanade', 600, 23, 3)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (49, 3, N'Club Sandwitch', 800, 23, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (50, 2, N'Tuna Sandwitch', 750, 23, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (51, 2, N'Tuna Sandwitch', 1500, 24, 2)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (52, 3, N'Club Sandwitch', 800, 24, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (53, 4, N'Coke,Lemanade', 200, 24, 1)
INSERT [dbo].[CheckDetail] ([Id], [ItemId], [ItemName], [Total], [CheckId], [Qty]) VALUES (54, 5, N'CreamSoda', 200, 24, 1)
SET IDENTITY_INSERT [dbo].[CheckDetail] OFF
SET IDENTITY_INSERT [dbo].[CheckSummary] ON 

INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (1, N'1', CAST(N'2017-02-07 14:41:00.000' AS DateTime), 200)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (2, N'2', CAST(N'2017-02-07 18:18:44.890' AS DateTime), 1350)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (3, N'3', CAST(N'2017-02-07 18:28:20.547' AS DateTime), 2200)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (4, N'4', CAST(N'2017-02-08 11:01:20.637' AS DateTime), 2550)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (5, N'6', CAST(N'2017-02-08 11:15:54.270' AS DateTime), 2200)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (6, N'7', CAST(N'2017-02-08 11:22:55.980' AS DateTime), 2150)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (7, N'8', CAST(N'2017-02-08 11:23:29.353' AS DateTime), 2150)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (8, N'5', CAST(N'2017-02-08 14:08:48.003' AS DateTime), 500)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (9, N'1', CAST(N'2017-02-08 16:57:39.003' AS DateTime), 0)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (10, N'2', CAST(N'2017-02-08 17:51:14.523' AS DateTime), 1900)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (11, N'2', CAST(N'2017-02-08 17:53:23.617' AS DateTime), 3300)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (12, N'3', CAST(N'2017-02-13 09:49:08.410' AS DateTime), 2000)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (13, N'9', CAST(N'2017-02-13 09:53:59.137' AS DateTime), 1750)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (14, N'10', CAST(N'2017-02-13 09:54:25.353' AS DateTime), 600)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (15, N'15', CAST(N'2017-02-13 10:48:47.203' AS DateTime), 2300)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (16, N'16', CAST(N'2017-02-13 11:40:18.413' AS DateTime), 3350)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (17, N'17', CAST(N'2017-02-13 11:46:27.853' AS DateTime), 1500)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (18, N'18', CAST(N'2017-02-13 14:01:23.647' AS DateTime), 2550)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (19, N'19', CAST(N'2017-02-13 16:36:28.673' AS DateTime), 2500)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (20, N'20', CAST(N'2017-02-13 16:37:01.473' AS DateTime), 2400)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (21, N'21', CAST(N'2017-02-13 16:37:37.263' AS DateTime), 600)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (22, N'22', CAST(N'2017-02-13 17:39:49.057' AS DateTime), 1350)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (23, N'23', CAST(N'2017-02-14 12:41:10.073' AS DateTime), 2150)
INSERT [dbo].[CheckSummary] ([Id], [CheckNo], [CreateDate], [Total]) VALUES (24, N'24', CAST(N'2017-02-15 13:16:17.537' AS DateTime), 2700)
SET IDENTITY_INSERT [dbo].[CheckSummary] OFF
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([Id], [ItemName], [Price], [Description], [Category]) VALUES (1, N'Chiken Burger', 500, N'Chiken,Cheese,Tomato,Gherkin,Onion.Served with French Frices', N'Food')
INSERT [dbo].[Item] ([Id], [ItemName], [Price], [Description], [Category]) VALUES (2, N'Tuna Sandwitch', 750, N'Tuna in oil,Cheese,Toast,Tomato,', N'Food')
INSERT [dbo].[Item] ([Id], [ItemName], [Price], [Description], [Category]) VALUES (3, N'Club Sandwitch', 800, N'Chicken,Ham,Toast,Egg,Tomato', N'Food')
INSERT [dbo].[Item] ([Id], [ItemName], [Price], [Description], [Category]) VALUES (4, N'Coke,Lemanade', 200, N'200ml', N'Beverage')
INSERT [dbo].[Item] ([Id], [ItemName], [Price], [Description], [Category]) VALUES (5, N'CreamSoda', 200, N'200ml', N'Beverage')
INSERT [dbo].[Item] ([Id], [ItemName], [Price], [Description], [Category]) VALUES (6, N'Orange Juice', 300, NULL, N'Beverage')
SET IDENTITY_INSERT [dbo].[Item] OFF
ALTER TABLE [dbo].[CheckDetail]  WITH CHECK ADD  CONSTRAINT [FK_CheckDetail_CheckSummary] FOREIGN KEY([CheckId])
REFERENCES [dbo].[CheckSummary] ([Id])
GO
ALTER TABLE [dbo].[CheckDetail] CHECK CONSTRAINT [FK_CheckDetail_CheckSummary]
GO
