Create proc [dbo].[CreateRoleGroupMap]
			@roleGroupId int,
			@roleId int
			AS
			Insert Into RoleGroupMap
			VALUES(@roleGroupId,@roleId)