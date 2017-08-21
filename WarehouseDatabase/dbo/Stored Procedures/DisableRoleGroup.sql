CREATE PROCEDURE [dbo].[DisableRoleGroup]
	@id int,
	@result int OUT
AS
BEGIN
	set @result = 0 -- SUCCESS

	IF @id=1 -- deactivation of admin roleGroup isn't allowed
		set @result = -4
	ELSE
	BEGIN
		IF(EXISTS(SELECT * FROM [dbo].[RoleGroup] WHERE [id] = @id AND IsActive = 1))
		BEGIN
			IF(EXISTS(SELECT * FROM [dbo].[User]  WHERE [roleGroupId] = @id and IsActive=1))
			BEGIN
			set @result = -3 -- there are active users with this roleGroupId
			END
			ELSE
			BEGIN			
				UPDATE [dbo].[RoleGroup]
				SET IsActive = 0
				WHERE id = @id			
			END
		END
		ELSE 
			set @result = -1
	END
END