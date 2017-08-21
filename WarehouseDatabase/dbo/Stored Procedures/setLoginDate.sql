create proc [dbo].[setLoginDate]
@UserId int
as
begin
if EXISTS(SELECT id from [User] where id = @UserId)
begin
	update [User]	 set lastLogindate = getdate() where id = @UserId;
end
end