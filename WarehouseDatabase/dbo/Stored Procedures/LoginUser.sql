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