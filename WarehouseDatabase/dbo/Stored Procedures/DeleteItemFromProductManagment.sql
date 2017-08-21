CREATE PROC [dbo].[DeleteItemFromProductManagment]
	@id int,
	@result int output
AS
BEGIN
	UPDATE dbo.ProductManagment
	SET 
		IsActive = 0, 
		lastModifyDate = GETDATE()
	WHERE
		id = @id
	Set @result = @@ROWCOUNT
END