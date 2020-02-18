use Agenda2017I013H
alter table dbo.Usuarios Add NumeroContactos int default 0
go
select * from dbo.Usuarios
go
create trigger ActualizarNumeroContactosBorrados on dbo.Contactos for delete
as
begin
	declare @NumeroContactos int
	declare @CodigoUsuario int
	set @CodigoUsuario = (select codigoUsuario from deleted)
	set @NumeroContactos = (select count(codigoContacto) from dbo.Contactos where codigoUsuario = @CodigoUsuario)
	update dbo.Usuarios set NumeroContactos = @NumeroContactos where codigoUsuario = @CodigoUsuario
end
go
select * from dbo.Contactos where codigoUsuario = 4
go
select * from dbo.Usuarios where codigoUsuario = 4
go
delete from Contactos where codigoContacto = 1004
go
select * from dbo.Usuarios inner join dbo.Contactos on Usuarios.codigoUsuario = Contactos.codigoUsuario
go
alter view vw_ContactoUsuarios 
as
select dbo.Contactos.codigoContacto,
       dbo.Contactos.apellidos,
	   dbo.Contactos.nombres,
	   Usuarios.codigoUsuario,
	   dbo.Usuarios.nombre,
	   dbo.Usuarios.email
from dbo.Contactos inner join dbo.Usuarios on dbo.Contactos.codigoUsuario = dbo.Usuarios.codigoUsuario
go
select * from vw_ContactoUsuarios where codigoUsuario = 4
go
select * from dbo.Usuarios


select ENCRYPTBYPASSPHRASE ('Password', '123');
select convert(varchar(50),DECRYPTBYPASSPHRASE ('Password', ENCRYPTBYPASSPHRASE ('Password', '123')));
go
update dbo.Usuarios set password = ENCRYPTBYPASSPHRASE(password,password)
go
select convert(nvarchar(50),DECRYPTBYPASSPHRASE('123', password)) from dbo.Usuarios where codigoUsuario = 4
go