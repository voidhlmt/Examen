create procedure consulta
@operacion varchar(50),
@codigo int

AS
Begin

if @operacion = 'articulo'
begin

	select Id, nombre, precio, exist from articulo where Id = @codigo

end
else

if @operacion = 'venta'
begin

	select Factura, fecha, total from ventas where Factura = @codigo

end

else
begin
print'Operación inválida';
end

End