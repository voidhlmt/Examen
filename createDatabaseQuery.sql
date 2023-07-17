create database examen

use examen

create table articulo(
ID int identity(1,1) primary key,
nombre varchar(50) not null,
precio int not null,
exist int not null
)

drop table ventas

create table ventas(
Factura int identity(1,1) primary key,
fecha datetime default getdate(),
total int not null
)

drop table ventas

insert into articulo(nombre, precio, exist) values('auto rojo', 20000, 10)
insert into articulo(nombre, precio, exist) values('auto azul', 10000, 40)
insert into articulo(nombre, precio, exist) values('auto negro', 30000, 20)
insert into articulo(nombre, precio, exist) values('auto blanco', 50000, 5)

insert into ventas(total) values(500000)
insert into ventas(total) values(100000)
insert into ventas(total) values(600000)
insert into ventas(total) values(20000000)

select * from articulo
select * from ventas
