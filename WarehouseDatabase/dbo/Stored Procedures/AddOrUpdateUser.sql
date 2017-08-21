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