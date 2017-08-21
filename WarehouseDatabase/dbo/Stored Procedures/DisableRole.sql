CREATE PROC [dbo].[DisableRole]
@Id INT,
@result int OUTPUT
AS
BEGIN
  BEGIN TRY
    UPDATE [Role] SET IsActive = 0 WHERE id = @Id
	SET @result = 1
  END TRY
  BEGIN CATCH
    SET @result = 0
  END CATCH
END