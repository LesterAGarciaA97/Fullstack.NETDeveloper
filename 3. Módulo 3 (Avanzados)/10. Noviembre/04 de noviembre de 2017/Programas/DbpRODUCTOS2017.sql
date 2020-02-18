create function fn_CalcularPrecioUnitario(@valor decimal(10,2))
returns decimal (10,2)
as
begin
	declare @resultado decimal(10,2)
	set @resultado = ((@valor/1.12) + ((@valor/1.12) * 0.25)) * 1.12
	return @resultado;
end;
go
select dbo.fn_CalcularPrecioUnitario(28.36)