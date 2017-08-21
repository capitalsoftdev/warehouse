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