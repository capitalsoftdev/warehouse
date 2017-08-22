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