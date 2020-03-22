USE [StudentDb]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON

INSERT [dbo].[Departments] ([Id], [Name]) VALUES (1, N'CSE')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (2, N'BBA')
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Students] ON

INSERT [dbo].[Students] ([Id], [RollNo], [Name], [Address], [Age], [DepartmentId]) VALUES (1, N'001', N'Arif', N'Dhaka', 20, 1)
INSERT [dbo].[Students] ([Id], [RollNo], [Name], [Address], [Age], [DepartmentId]) VALUES (2, N'002', N'Asif', N'Jessore', 30, 1)
INSERT [dbo].[Students] ([Id], [RollNo], [Name], [Address], [Age], [DepartmentId]) VALUES (3, N'003', N'Belal', N'Dhaka', 22, 1)
INSERT [dbo].[Students] ([Id], [RollNo], [Name], [Address], [Age], [DepartmentId]) VALUES (4, N'004', N'Sufyaan', N'Savar', 10, 1)
INSERT [dbo].[Students] ([Id], [RollNo], [Name], [Address], [Age], [DepartmentId]) VALUES (5, N'005', N'Siam', N'Mirpur', 15, 2)
INSERT [dbo].[Students] ([Id], [RollNo], [Name], [Address], [Age], [DepartmentId]) VALUES (6, N'006', N'Raisa', N'Motijhil', 18, 2)
INSERT [dbo].[Students] ([Id], [RollNo], [Name], [Address], [Age], [DepartmentId]) VALUES (7, N'007', N'Adiba', N'Mohammadpu', 35, 2)
INSERT [dbo].[Students] ([Id], [RollNo], [Name], [Address], [Age], [DepartmentId]) VALUES (8, N'008', N'Arif', N'Uttora', 31, 2)
SET IDENTITY_INSERT [dbo].[Students] OFF