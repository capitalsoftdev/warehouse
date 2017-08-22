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