CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[roleGroupId] [int] NOT NULL,
	[creationDate] [datetime] NOT NULL,
	[lastLogindate] [datetime] NULL,
	[lastModifyDate] [datetime] NOT NULL,
	[IsActive] [bit] NULL CONSTRAINT [DF_User_IsActive]  DEFAULT ((1))
) ON [PRIMARY]