USE [SECURITY_DB]
GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 2019-10-31 12:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[UserID] [int] NOT NULL,
	[UserName] [varchar](50) NULL,
	[UserPassword] [varchar](50) NULL,
	[UserRoles] [varchar](500) NULL,
	[UserEmailID] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[UserMaster] ([UserID], [UserName], [UserPassword], [UserRoles], [UserEmailID]) VALUES (101, N'Anurag', N'123456', N'Admin', N'Anurag@g.com')
INSERT [dbo].[UserMaster] ([UserID], [UserName], [UserPassword], [UserRoles], [UserEmailID]) VALUES (102, N'Priyanka', N'abcdef', N'User', N'Priyanka@g.com')
INSERT [dbo].[UserMaster] ([UserID], [UserName], [UserPassword], [UserRoles], [UserEmailID]) VALUES (103, N'Sambit', N'123pqr', N'SuperAdmin', N'Sambit@g.com')
INSERT [dbo].[UserMaster] ([UserID], [UserName], [UserPassword], [UserRoles], [UserEmailID]) VALUES (104, N'Pranaya', N'abc123', N'Admin, User', N'Pranaya@g.com')
