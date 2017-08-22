CREATE PROC [dbo].[GetItemFromProductManagment]
	@id int = NULL,
	@userId int = NULL,
	@productId int = NULL
AS
BEGIN
	IF @id IS NOT NULL
		SELECT * 
		FROM dbo.ProductManagment 
		WHERE id = @id and isActive = 1

	ELSE IF @userId IS NOT NULL
		SELECT * 
		FROM dbo.ProductManagment 
		WHERE userId = @userId and isActive = 1

	ELSE IF @productId IS NOT NULL
		SELECT * 
		FROM dbo.ProductManagment 
		WHERE productId = @productId and isActive = 1
	ELSE
		SELECT * 
		FROM dbo.ProductManagment  Where isActive = 1
END