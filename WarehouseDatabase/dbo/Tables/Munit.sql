--use Warehouse
CREATE TABLE [dbo].[Munit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](10) NOT NULL,
	[isActive] [bit] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Munit] ADD  CONSTRAINT [DF_Munit_isActive]  DEFAULT ((1)) FOR [isActive]