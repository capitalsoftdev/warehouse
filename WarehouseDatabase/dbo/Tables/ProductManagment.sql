CREATE TABLE [dbo].[ProductManagment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productId] [int] NOT NULL,
	[quantity] [decimal](18, 2) NOT NULL,
	[actionDate] [datetime] NOT NULL CONSTRAINT [DF_ProductMangement_actionDate]  DEFAULT (getdate()),
	[action] [int] NOT NULL CONSTRAINT [DF_ProductMangement_action]  DEFAULT ((1)),
	[userId] [int] NOT NULL,
	[reason] [nvarchar](512) NULL,
	[price] [decimal](18, 2) NOT NULL,
	[supplierId] [int] NOT NULL,
	[brand] [nvarchar](128) NULL,
	[lastModifyDate] [datetime] NULL CONSTRAINT [DF_LastModifyDate]  DEFAULT (getdate()),
	[isActive] [bit] NULL DEFAULT ((1))
) ON [PRIMARY]