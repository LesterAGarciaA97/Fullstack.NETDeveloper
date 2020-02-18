use Agenda2017I013H
alter table dbo.Usuarios Add NumeroContactos int default 0
go
select * from dbo.Usuarios
go
alter trigger ActualizarNumeroContactos on dbo.Contactos for insert
as
begin
	declare @NumeroContactos int
	declare @CodigoUsuario int
	set @CodigoUsuario = (select codigoUsuario from inserted)
	set @NumeroContactos = (select count(codigoContacto) from dbo.Contactos where codigoUsuario = @CodigoUsuario)
	update dbo.Usuarios set NumeroContactos = @NumeroContactos where codigoUsuario = @CodigoUsuario
end
go
select * from dbo.Usuarios where codigoUsuario = 4
go
select count(codigoContacto) from dbo.Contactos where codigoUsuario = 5
go
insert into dbo.Contactos (apellidos,nombres,codigoUsuario) values ('Vasquez', 'Pedro',4)
go
select * from dbo.Contactos where codigoUsuario = 4
go
select * from dbo.Usuarios where codigoUsuario = 4