CREATE PROCEDURE [dbo].[GetProduct]
	@id int = null
AS
BEGIN
	IF(@id IS NULL)
		SELECT * FROM Product
	ELSE IF(EXISTS(SELECT * FROM Product WHERE id = @id))
		SELECT * FROM Product WHERE id = @id
END