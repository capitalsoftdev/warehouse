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