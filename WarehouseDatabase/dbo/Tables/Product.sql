CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productCategoryId] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[munit] [int] NOT NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]