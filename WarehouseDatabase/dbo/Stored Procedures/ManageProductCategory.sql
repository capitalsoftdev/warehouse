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