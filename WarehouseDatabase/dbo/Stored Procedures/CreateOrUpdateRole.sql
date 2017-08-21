CREATE PROC [dbo].[CreateOrUpdateRole]
@id INT,
@name varchar(50),
@isActive bit,
@result int output
AS
BEGIN
 SET @result = 0
 IF((@id = -1) OR NOT EXISTS(SELECT id FROM [Role] WHERE id=@id))  
 BEGIN TRY 
   INSERT INTO [Role](name,isActive) VALUES (@name ,@isActive)
   SET  @result = 1
 END TRY
 BEGIN CATCH
   SET @result = 3
 END CATCH
 ELSE
 BEGIN TRY
   UPDATE [Role] Set name = ISNULL(@name,name),isActive = ISNULL(@isActive,IsActive)WHERE id = @id
   SET @result = 2
 END TRY
 BEGIN CATCH
   SET @result = 3
 END CATCH
END