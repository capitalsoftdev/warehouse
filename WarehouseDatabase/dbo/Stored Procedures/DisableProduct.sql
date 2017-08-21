CREATE PROCEDURE [dbo].[DisableProduct]
	@id int,
	@status int OUTPUT -- if status = 1 then such product already active in warehouse
						   -- if status = 2 then such product already not active in warehouse
AS
BEGIN
	set @status = 0
	IF(EXISTS(SELECT * FROM [dbo].[ProductManagment] WHERE [productId] = @id AND IsActive = 0))
		BEGIN
			UPDATE Product
			SET IsActive = 0
			WHERE id = @id
			SET @status = 1
		END
	ELSE IF(EXISTS(SELECT * FROM [dbo].[ProductManagment] WHERE productId = @id AND IsActive = 1))
			IF(((SELECT SUM(quantity) FROM [dbo].[ProductManagment] WHERE productId = @id AND  [action] = 1) 
			- (SELECT SUM(quantity) FROM [dbo].[ProductManagment] WHERE productId = @id AND [action] = 2)) = 0)
				BEGIN
					SET @status = 2
					UPDATE Product
					SET IsActive = 0
					WHERE id = @id
				END
			ELSE
				SET @status = 3
				
		BEGIN
			begin
					set @status = 2
					UPDATE Product
					SET IsActive = 0
					WHERE id = @id
				end
			
			
		END
END