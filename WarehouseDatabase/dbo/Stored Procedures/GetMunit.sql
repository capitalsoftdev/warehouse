Create PROCEDURE [dbo].[GetMunit]
	@id int
AS
BEGIN
	IF(@id < 1)
		begin 
			select * from Munit
		end
	else if(exists(select * from munit where id = @id))
		begin
			SELECT * FROM Munit where id = @id
		end
END