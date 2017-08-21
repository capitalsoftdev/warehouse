CREATE TABLE [dbo].[RoleGroup](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] NVARCHAR(50) NOT NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]