CREATE TABLE [dbo].[ProductCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[parentId] [int] NULL,
	[IsActive] [bit] NULL CONSTRAINT [DF_IsActive]  DEFAULT ((1))
) ON [PRIMARY]