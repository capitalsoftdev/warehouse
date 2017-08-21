CREATE Proc [dbo].[CreateOrUpdateProductManagment]
	@id int = NULL,
	@productId int,
	@quantity decimal(18, 2),
	@actionDate datetime,
	@action int,
	@userId int,
	@reason nvarchar(512) = NULL,
	@price decimal(18,2),
	@supplierId int,
	@brand nvarchar(128) = NULL,
	@lastModifyDate datetime = NULL,
	@IsActive bit = NULL,
	@res int  output
AS
BEGIN
	SET NOCOUNT ON;
	IF @id is null
	Begin
		INSERT INTO dbo.ProductManagment
		(
			productId,
			quantity, 
			actionDate,
			[action],
			userId, 
			reason,
			price, 
			supplierId, 
			brand ,
			lastModifyDate, 
			IsActive 
		)
		Values
		(
			@productId,
			@quantity, 
			@actionDate,
			@action,
			@userId,
			@reason, 
			@price, 
			@supplierId, 
			@brand ,
			@lastModifyDate, 
			@IsActive 
		)
		SET @res = Scope_Identity()
		--Set @res = 5
		End
	ELSE 
	--if exists(select * from ProductManagment where id = @id)
	Begin
		UPDATE dbo.ProductManagment
			SET 
			productId = @productId,
			quantity = @quantity, 
			actionDate = @actionDate,
			[action] = @action,
			userId = @userId,
			reason = @reason,
			price = @price, 
			supplierId = @supplierId, 
			brand = @brand,
			lastModifyDate = @lastModifyDate, 
			IsActive = @IsActive
		Where 
			id = @id
			if @@ROWCOUNT > 0 
		Set @res = @id
		else 
		set @res = -1

	End 
END