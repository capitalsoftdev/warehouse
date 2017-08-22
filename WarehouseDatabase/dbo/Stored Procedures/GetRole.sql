CREATE PROC [dbo].[GetRole]
@id int
AS
BEGIN
  IF(@id = -1)
  BEGIN
  SELECT * FROM [Role]
  END
  ELSE
  BEGIN
  SELECT * FROM [Role] WHERE id = @id
  END
END