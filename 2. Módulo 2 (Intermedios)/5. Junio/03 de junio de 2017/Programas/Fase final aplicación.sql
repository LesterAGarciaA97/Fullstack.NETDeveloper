use Agenda2017I013H
go
create procedure sp_AgregarContacto @Nombres varchar(128), @Apellidos varchar(128), @CodigoUsuario int
as
begin
	insert into dbo.Contactos (apellidos,nombres,codigoUsuario)
	values (@Apellidos, @Nombres, @CodigoUsuario)
end

create procedure sp_EliminarContacto @CodigoContacto int
as
begin
	delete from dbo.Contactos where codigoContacto = @CodigoContacto
end
