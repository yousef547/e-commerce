USE [EcommerceDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/09/2023 12:16:40 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductBrands]    Script Date: 19/09/2023 12:16:40 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductBrands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductBrands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 19/09/2023 12:16:40 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[PictureUrl] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[ProductBrandId] [int] NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 19/09/2023 12:16:40 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230918081739_createDb', N'6.0.11')
GO
SET IDENTITY_INSERT [dbo].[ProductBrands] ON 

INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (1, N'Angular')
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (2, N'NetCore')
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (3, N'VS Code')
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (4, N'React')
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (5, N'Typescript')
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (6, N'Redis')
SET IDENTITY_INSERT [dbo].[ProductBrands] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (15, N'Angular Speedster Board 2000', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/sb-ang1.png', CAST(200 AS Decimal(18, 0)), 1, 1)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (16, N'Green Angular Board 3000', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/sb-ang2.png', CAST(200 AS Decimal(18, 0)), 1, 1)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (17, N'Core Board Speed Rush 3', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/sb-ang2.png', CAST(200 AS Decimal(18, 0)), 1, 2)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (18, N'Net Core Super Board', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/sb-core1.png', CAST(200 AS Decimal(18, 0)), 1, 2)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (19, N'React Board Super Whizzy Fast', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/sb-core2.png', CAST(200 AS Decimal(18, 0)), 1, 4)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (20, N'Typescript Entry Board', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/sb-ts1.png', CAST(200 AS Decimal(18, 0)), 1, 5)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (21, N'Core Blue Hat', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/hat-core1.png', CAST(200 AS Decimal(18, 0)), 2, 2)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (22, N'Purple React Woolen Hat', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/hat-react1.png', CAST(200 AS Decimal(18, 0)), 2, 4)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (23, N'Green React Woolen Hat', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/hat-react2.png', CAST(200 AS Decimal(18, 0)), 4, 3)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (24, N'Blue Code Gloves', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/glove-code1.png', CAST(200 AS Decimal(18, 0)), 4, 3)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (25, N'Green Code Gloves', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/glove-code2.png', CAST(200 AS Decimal(18, 0)), 4, 4)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (26, N'Purple React Gloves', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/glove-react1.png', CAST(200 AS Decimal(18, 0)), 4, 4)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (27, N'Green React Gloves', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/glove-react2.png', CAST(200 AS Decimal(18, 0)), 3, 6)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (28, N'Redis Red Boots', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/boot-redis1.png', CAST(200 AS Decimal(18, 0)), 3, 2)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (29, N'Core Red Boots', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/boot-core2.png', CAST(200 AS Decimal(18, 0)), 2, 3)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (30, N'Core Purple Boots', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/boot-core1.png', CAST(200 AS Decimal(18, 0)), 3, 1)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (31, N'Angular Purple Boots', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/boot-ang2.png', CAST(200 AS Decimal(18, 0)), 3, 1)
INSERT [dbo].[products] ([Id], [Name], [Description], [PictureUrl], [Price], [ProductTypeId], [ProductBrandId]) VALUES (32, N'Angular Blue Boots', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.', N'images/products/boot-ang1.png', CAST(200 AS Decimal(18, 0)), 1, 2)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (1, N'Boards')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (2, N'Hats')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (3, N'Boots')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (4, N'Gloves')
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_ProductBrands_ProductBrandId] FOREIGN KEY([ProductBrandId])
REFERENCES [dbo].[ProductBrands] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_ProductBrands_ProductBrandId]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_ProductTypes_ProductTypeId] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_ProductTypes_ProductTypeId]
GO
