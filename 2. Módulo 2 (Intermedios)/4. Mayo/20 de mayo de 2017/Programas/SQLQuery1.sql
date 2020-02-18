USE [Agenda2017I013H]
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarContactosPorUsuario]    Script Date: 20/05/2017 12:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_ConsultarContactosPorUsuario] @CodigoUsuario int
as
begin
	select codigoContacto,apellidos,nombres from Contactos where codigoUsuario = @CodigoUsuario
end