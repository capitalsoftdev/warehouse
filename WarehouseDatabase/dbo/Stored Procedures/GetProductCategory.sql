CREATE procedure [dbo].[GetProductCategory]
@id int = null
as
begin
if (@id is null) 
select * from ProductCategory 
else 
select * from ProductCategory where id=@id
end