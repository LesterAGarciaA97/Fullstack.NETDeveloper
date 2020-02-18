use Agenda2017I013H
go
select * from dbo.Roles
go
select * from dbo.Usuarios
go
create procedure sp_AgregarUsuario @nombre varchar(128), 
	@login varchar(128), @password varchar(128), @email varchar(128), 
	@codigoRol int
as
begin
insert into dbo.Usuarios (nombre,login,password,email,codigoRol)
values(@nombre,@login,@password,@email,@codigoRol)
end
go
create procedure sp_EliminarUsuario @CodigoUsuario int 
as
begin
delete from Usuarios where codigoUsuario = @codigoUsuario
end
go
create procedure sp_ModificarUsuario @CodigoUsuario int,
	@nombre varchar(128), @login varchar(128), @password varchar(128),
	@email varchar(128), @rol int
as
begin
update Usuarios set nombre = @nombre, login = @login, password = @password,
	email = @email, codigoRol = @rol where codigoUsuario = @CodigoUsuario
end
execute sp_ModificarUsuario 2, 'Juan Alberto Patal', 'alberto', 'Guatemala', 'jp@es.com', 1
select * form usuarios
update Usuarios set login ='LopezR' where codigoUsuario = 3
update Usuarios set nombre = 'Juan Patal', email = 'juanpatal@yahoo.com' where codigoUsuario = 3
select * from Usuarios
execute sp_AgregarUsuario 'Juan Pérez','JCPerez','123','juanperez@gmail.com',1
execute sp_EliminarUsuario 1

create procedure sp_ConsultarUsuarios
as
begin
select codigoUsuario, nombre, login, password, email, codigoRol from Usuarios
end