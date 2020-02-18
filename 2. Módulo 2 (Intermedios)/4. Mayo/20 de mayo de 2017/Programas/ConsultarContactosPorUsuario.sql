create procedure sp_ConsultarContactosPorUsuario @CodigoUsuario int
as
begin
	select codigoContacto,apellidos,nombres from Contactos
end
go
execute sp_ConsultarContactosPorUsuario 1