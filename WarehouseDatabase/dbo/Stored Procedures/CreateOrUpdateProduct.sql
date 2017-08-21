CREATE PROCEDURE [dbo].[CreateOrUpdateProduct]
	@id int = null,
	@productCategoryId int = null,
	@name nvarchar(100) = null,
	@munit int = null,
	@status int OUTPUT -- if status = 1 then such product already exists if status = 2 then system error
						-- if status = 3 then some  filder is null
AS
BEGIN 
	SET @status = 0
	IF(@id IS NULL)
		IF(EXISTS(SELECT * FROM Product 
					WHERE productCategoryId = ISNULL(@productCategoryId, productCategoryId)
					AND name = ISNULL(@name, name) AND munit = ISNULL(@munit, munit)))
				SET @status = 1
		ELSE
			BEGIN TRY
				IF(@productCategoryId IS NOT NULL AND @name IS NOT NULL AND @munit IS NOT NULL)
					INSERT INTO Product(productCategoryId, name, munit, IsActive)
					VALUES (@productCategoryId, @name, @munit, 1)
				ELSE 
					SET @status = 3
			END TRY
			BEGIN CATCH
				SET @status = 2
			END CATCH
	ELSE
		BEGIN TRY
			UPDATE Product
			SET productCategoryId = ISNULL(@productCategoryId, productCategoryId), 
			name = ISNULL(@name, name), munit = ISNULL(@munit, munit)
			WHERE id = @id
		END TRY
		BEGIN CATCH
			SET @status = 2
		END CATCH
END