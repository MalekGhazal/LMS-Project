USE [LMS]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 6/19/2023 10:55:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[Book_ID] [int] NOT NULL,
	[User_ID] [int] NULL,
	[Title] [nchar](10) NULL,
	[Author] [nchar](10) NULL,
	[ISBN] [nchar](10) NULL,
	[Category] [nchar](10) NULL,
	[Price] [decimal](18, 1) NULL,
	[Status] [nchar](10) NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Book_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/19/2023 10:55:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[User_ID] [int] NOT NULL,
	[User_Lname] [nchar](10) NULL,
	[User_Fname] [nchar](10) NULL,
	[User_Username] [nchar](30) NULL,
	[User_Password] [nchar](30) NULL,
	[User_Phone] [nchar](10) NULL,
	[User_Email] [nchar](20) NULL,
	[User_Role] [nchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (1, N'Kailey    ', N'Mcclain   ', N'admin                         ', N'123456                        ', N'4381234567', N'Kailey@gmail.com    ', N'Staff     ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (2, N'Aldo      ', N'Hale      ', N'aldohale                      ', N'654321                        ', N'438123456 ', N'aldo.h@gmail.com    ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (3, N'Evie      ', N'Grant     ', N'evie123                       ', N'654321                        ', N'438123456 ', N'evie.g@gmail.com    ', N'Supplier  ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (4, N'Soren     ', N'Malone    ', N'soren111                      ', N'123456                        ', N'438123456 ', N'soren.m@gmail.com   ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (5, N'Abigail   ', N'Wyatt     ', N'abigail5                      ', N'12345                         ', N'5551234567', N'abigail.w@gmail.com ', N'Staff     ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (6, N'Dayana    ', N'Boyle     ', N'dayana6                       ', N'12345                         ', N'1231234567', N'dayana.b@gmail.com  ', N'Staff     ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (7, N'Joe       ', N'Butler    ', N'joe7                          ', N'12345                         ', N'1231276543', N'joe.b@gmail.com     ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (8, N'Gaven     ', N'Park      ', N'gaven8                        ', N'12345                         ', N'1231276543', N'gaven.g@gmail.com   ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (9, N'Sariah    ', N'Hansen    ', N'sariah9                       ', N'12345                         ', N'4381276543', N'sariah.h@gmail.com  ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (10, N'Gillian   ', N'Cross     ', N'gillian10                     ', N'12345                         ', N'4381234567', N'gillian.c@gmail.com ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (11, N'Alaina    ', N'Hogan     ', N'alaina11                      ', N'12345                         ', N'4381234567', N'alaina.h@gmail.com  ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (12, N'Finley    ', N'Benitez   ', N'finley12                      ', N'12345                         ', N'4381234567', N'finley.b@gmail.com  ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (13, N'Janelle   ', N'Fisher    ', N'janelle13                     ', N'12345                         ', N'4381234567', N'janelle.f@gmail.com ', N'User      ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (14, N'Lara      ', N'Webster   ', N'lara14                        ', N'12345                         ', N'4381234567', N'lara.w@gmail.com    ', N'Supplier  ')
INSERT [dbo].[User] ([User_ID], [User_Lname], [User_Fname], [User_Username], [User_Password], [User_Phone], [User_Email], [User_Role]) VALUES (15, N'Grady     ', N'Robinson  ', N'grady15                       ', N'12345                         ', N'4381234567', N'grady.r@gmail.com   ', N'Supplier  ')
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_User] FOREIGN KEY([User_ID])
REFERENCES [dbo].[User] ([User_ID])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_User]
GO
