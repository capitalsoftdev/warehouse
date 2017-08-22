CREATE PROCEDURE [dbo].[GetRoleGroup]
	@id int
	,@result int out
AS
BEGIN
	SET @result = 0 -- success
	IF(@id IS NULL)
		SELECT * FROM RoleGroup
	ELSE IF(EXISTS(SELECT * FROM RoleGroup WHERE id = @id))
		SELECT * FROM RoleGroup WHERE id = @id
	ELSE SET @result = -3 -- not exists
END