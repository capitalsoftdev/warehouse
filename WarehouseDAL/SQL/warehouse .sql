--use Warehouse
CREATE TABLE [dbo].[Munit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](10) NOT NULL,
	[isActive] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productCategoryId] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[munit] [int] NOT NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[parentId] [int] NULL,
	[IsActive] [bit] NULL CONSTRAINT [DF_IsActive]  DEFAULT ((1))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductManagment]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductManagment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productId] [int] NOT NULL,
	[quantity] [decimal](18, 2) NOT NULL,
	[actionDate] [datetime] NOT NULL CONSTRAINT [DF_ProductMangement_actionDate]  DEFAULT (getdate()),
	[action] [int] NOT NULL CONSTRAINT [DF_ProductMangement_action]  DEFAULT ((1)),
	[userId] [int] NOT NULL,
	[reason] [nvarchar](512) NULL,
	[price] [decimal](18, 2) NOT NULL,
	[supplierId] [int] NOT NULL,
	[brand] [nvarchar](128) NULL,
	[lastModifyDate] [datetime] NULL CONSTRAINT [DF_LastModifyDate]  DEFAULT (getdate()),
	[isActive] [bit] NULL DEFAULT ((1))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoleGroup]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoleGroup](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoleGroupMap]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleGroupMap](
	[roleGroupId] [int] NOT NULL,
	[roleId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[roleGroupId] [int] NOT NULL,
	[creationDate] [datetime] NOT NULL,
	[lastLogindate] [datetime] NULL,
	[lastModifyDate] [datetime] NOT NULL,
	[IsActive] [bit] NULL CONSTRAINT [DF_User_IsActive]  DEFAULT ((1))
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Munit] ADD  CONSTRAINT [DF_Munit_isActive]  DEFAULT ((1)) FOR [isActive]
GO
/****** Object:  StoredProcedure [dbo].[AddOrUpdateUser]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddOrUpdateUser]
@UserId int=null,
@UserName varchar(20)=null,
@Password varchar(50)=null,
@RoleGroupId int=null,
@lastLogindate datetime = null
as
begin
  if EXISTS(SELECT id from [User] where id = @UserId)
  begin
    if(@UserName is not null) update [User]	 set username = @UserName	 where id =@UserId
	if(@Password is not null) update [User]	 set [password] = @Password 	 where id =@UserId
	if(@RoleGroupId is not null) update [User]	 set roleGroupId = @RoleGroupId	 where id =@UserId
	update [User] set lastModifyDate = GETDATE()
  end 
  else
  begin	
    begin try
         insert into [User] (username, [password], roleGroupId,   creationDate,  lastLogindate,  lastModifyDate,   IsActive)
			         values(@UserName, @Password,  @RoleGroupId,  GETDATE(),     null,	         GETDATE(),        1)  
	end try
	begin catch
	    print'Wrong parametr inserted'
	end catch
  end
end
GO
/****** Object:  StoredProcedure [dbo].[Autorisation]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Autorisation]
@username varchar(20),
@password varchar(50),
@output int output
as 
begin
	if Exists(select * from [User] where username = @username and [password] = @password)
		begin
			set @output = (select id from [User] where  username = @username and [password] = @password)
		end
	else
		begin
			set @output = 0
		end
end
GO
/****** Object:  StoredProcedure [dbo].[ChangeIsActive]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[ChangeIsActive]
@UserId int
AS
begin
   if (Select IsActive from [User] where id =@UserId) = 0
   begin
		update [User]
		set IsActive = 1 
		where id = @UserId
   end
   else if(Select IsActive from [User] where id =@UserId) = 1
   begin
		update [User]
		set IsActive = 0 
		where id = @UserId
   end
end
GO
/****** Object:  StoredProcedure [dbo].[CreateOrUpdateProduct]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[CreateOrUpdateProductCategory]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CreateOrUpdateProductCategory]
@id int =null,
@name nvarchar (50),
@parentId int =null,
@status int out
as
begin
if(@id is null)
begin
insert into ProductCategory (name, parentId)
values (@name, @parentId)
set @status = 1
end
else 
begin
update productcategory set 
name=@name, 
parentId=@parentId
where id=@id 

if @@ROWCOUNT > 0
set @status=0
else
set @status=-1
end
end
GO
/****** Object:  StoredProcedure [dbo].[CreateOrUpdateProductManagment]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[CreateOrUpdateRole]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[CreateRoleGroupMap]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[CreateRoleGroupMap]
			@roleGroupId int,
			@roleId int
			AS
			Insert Into RoleGroupMap
			VALUES(@roleGroupId,@roleId)
GO
/****** Object:  StoredProcedure [dbo].[DeleteItemFromProductManagment]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
/****** Object:  StoredProcedure [dbo].[DisableProduct]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DisableProduct]
	@id int,
	@status int OUTPUT -- if status = 1 then such product already active in warehouse
						   -- if status = 2 then such product already not active in warehouse
AS
BEGIN
	set @status = 0
	IF(EXISTS(SELECT * FROM [dbo].[ProductManagment] WHERE [productId] = @id AND IsActive = 0))
		BEGIN
			UPDATE Product
			SET IsActive = 0
			WHERE id = @id
			SET @status = 1
		END
	ELSE IF(EXISTS(SELECT * FROM [dbo].[ProductManagment] WHERE productId = @id AND IsActive = 1))
			IF(((SELECT SUM(quantity) FROM [dbo].[ProductManagment] WHERE productId = @id AND  [action] = 1) 
			- (SELECT SUM(quantity) FROM [dbo].[ProductManagment] WHERE productId = @id AND [action] = 2)) = 0)
				BEGIN
					SET @status = 2
					UPDATE Product
					SET IsActive = 0
					WHERE id = @id
				END
			ELSE
				SET @status = 3
				
		BEGIN
			begin
					set @status = 2
					UPDATE Product
					SET IsActive = 0
					WHERE id = @id
				end
			
			
		END
END
GO
/****** Object:  StoredProcedure [dbo].[DisableRole]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[GetActiveProduct]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetActiveProduct]
AS
BEGIN
	SELECT * FROM Product WHERE IsActive = 1
END 

GO
/****** Object:  StoredProcedure [dbo].[GetItemFromProductManagment]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
/****** Object:  StoredProcedure [dbo].[GetMunit]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[GetProduct]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProduct]
	@id int = null
AS
BEGIN
	IF(@id IS NULL)
		SELECT * FROM Product
	ELSE IF(EXISTS(SELECT * FROM Product WHERE id = @id))
		SELECT * FROM Product WHERE id = @id
END 
GO
/****** Object:  StoredProcedure [dbo].[GetProductCategory]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetProductCategory]
@id int = null
as
begin
if (@id is null) 
select * from ProductCategory 
else 
select * from ProductCategory where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[GetRole]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[GetRoleGroupMap]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetRoleGroupMap]
AS
Select * From RoleGroupMap;
GO
/****** Object:  StoredProcedure [dbo].[LoginUser]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoginUser]
@Login varchar(20),
@Password varchar(50)
as
begin
if((select username from [User] where username=@Login)=@Login)
	begin
		if((select [password] from [User] where username=@Login)=CONVERT(varchar(50), HASHBYTES('MD5', @Password), 1))
		begin 
			print'You are logged in'
		end
		else
		begin 
			print'Wrong Password'
		end
	end
	else
	begin 
			print'Wrong Login'
	end
end
GO
/****** Object:  StoredProcedure [dbo].[ManageProductCategory]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ManageProductCategory]
@id int ,
@action int ,
@status int out
as
begin
if(@action=1)
begin

update ProductCategory set IsActive=0 where id=@id or parentId=@id

update product set isActive=0 where id in (
select id from Product where productCategoryId in (select id from ProductCategory where parentId=@id )
or productCategoryId=@id)
end
if(@action=2)
begin

update ProductCategory set IsActive=1 where id=@id or parentId=@id

update product set isActive=1 where id in (
select id from Product where productCategoryId in (select id from ProductCategory where parentId=@id )
or productCategoryId=@id)
end
end
GO
/****** Object:  StoredProcedure [dbo].[SelectActiveUsers]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectActiveUsers]
@UserId int = null
as
begin
	if(@UserId is null)
		begin
			select * from [User] where IsActive=1
		end
	else 
		begin
			if((select id from [User] where id=@UserId and IsActive=1)is not null)
				begin
					select * from [User] where id = @UserId
				end
		end
end
GO
/****** Object:  StoredProcedure [dbo].[setLoginDate]    Script Date: 22.08.2017 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[setLoginDate]
@UserId int
as
begin
if EXISTS(SELECT id from [User] where id = @UserId)
begin
	update [User]	 set lastLogindate = getdate() where id = @UserId;
end
end
GO
USE [master]
GO
ALTER DATABASE [Warehouse] SET  READ_WRITE 
GO
