CREATE PROCEDURE [dbo].[CreateOrUpdateRoleGroup]
	@id int,	
	@name nvarchar(50),	
	@result int out 
AS
BEGIN 
	SET @result = 0 --SUCCESS

	BEGIN TRY
	BEGIN
		IF(@id IS NULL) -- create from scratch
		BEGIN
			INSERT INTO RoleGroup(name, IsActive)
			VALUES (@name, 1)
			
			SET @result = SCOPE_IDENTITY() -- return new created user id					
		END
		ELSE
		BEGIN
			UPDATE RoleGroup
			SET name = ISNULL(@name, name)			
			WHERE id = @id

			if @@ROWCOUNT<1
			BEGIN
				SET @result = -1
			END
		END
	END
END TRY
BEGIN CATCH
	IF ERROR_NUMBER() = 2627 -- unique index violation exception
		SET @result = -3
	else
		SET @result = -2 -- internal error
END CATCH
END