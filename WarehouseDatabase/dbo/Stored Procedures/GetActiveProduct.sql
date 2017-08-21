Create PROCEDURE [dbo].[GetActiveProduct]
AS
BEGIN
	SELECT * FROM Product WHERE IsActive = 1
END