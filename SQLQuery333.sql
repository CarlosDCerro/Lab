create database TiendaNaturista
go

use TiendaNaturista
go

create table Clientes(
cliDocumento char(11) not null,
cliNombre varchar(50) not null,
cliDireccion varchar(50) not null,
cliTelefono char(11) not null,
cliCorreo varchar(50) not null,
constraint PK_Clientes primary key clustered
(
cliDocumento asc
) with (pad_index = off, statistics_norecompute = off, ignore_dup_key = off, allow_row_locks = on, allow_page_locks = on)on [primary]
) on [primary]

go

insert into Clientes values ('42918785','Dayana Pacheco','Calle 1','3233770258','dayanapacheco@mail.com')
insert into Clientes values ('92485277','Matías Cerro','Calle34','3161234789','matiascerro@mail.com')
insert into Clientes values ('36215784','Gabrielle Rodríguez','Calle 5','3142348900','gabriellerodriguez@mail.com')
insert into Clientes values ('12567987','Marlene Morales','Calle 7','3164932389','marlenemorales@mail.com')
go

select*from Clientes;

--Procedimiento Almacenado Insertar == Clientes

create procedure sp_InserterClientes
(
@cliDocumentos char(11),
@cliNombre varchar(50),
@cliDireccion varchar(50),
@cliTelefono char(11),
@cliCorreo varchar(50)
)
as
insert into Clientes (cliDocumento, cliNombre, cliDireccion, cliTelefono, cliCorreo)
values (@cliDocumentos, @cliNombre, @cliDireccion, @cliTelefono, @cliCorreo)
go

--Procedimiento Almacenado Consultar == Clientes

create procedure sp_ConsultarClientes
as
select * from Clientes
go

--Porcedimiento Almacenado Modificar == Cliente

create procedure sp_ModificarClientes
(
@cliDocumento char(11),
@cliNombre varchar(50),
@cliDireccion varchar(50),
@cliTelefono char(11),
@cliCorreo varchar(50)
)
as
update Clientes set cliNombre=@cliNombre, cliDireccion=@cliDireccion, @cliTelefono=@cliTelefono, cliCorreo=@cliCorreo where @cliDocumento = @cliDocumento
go

--Procedimiento Almacenado Eliminar == Clientes

create procedure sp_EliminarClientes
(
@cliDocumento char(11),
@cliNombre varchar(50),
@cliDireccion varchar(50),
@cliTelefono char(11),
@cliCorreo varchar(50)
)
as
delete from Clientes where cliDocumento=@cliDocumento and cliNombre=@cliNombre and cliDireccion=@cliDireccion and cliTelefono=@cliTelefono and cliCorreo=@cliCorreo
go


create table Vendedores(
venUsuario char(11) not null,
venContraseña varchar (10) not null,
constraint PK_Vendedores primary key clustered
(
venUsuario asc
)with (pad_index = off, statistics_norecompute = off, ignore_dup_key = off, allow_row_locks = on, allow_page_locks = on)on [primary]
)on [primary]

go

insert into Vendedores
values ('Cerro','12345')
go

select * from Vendedores where venUsuario='Cerro' and venContraseña='12345'
go


declare @user char(11)='Cerro'
declare @pass varchar(10)='12345'
select * from Vendedores where venUsuario=@user and venContraseña=@pass
go

-- Procedimiento almacenado Ingresar / Validar vendedor 
create procedure sp_IngresarVendendor
(
@user char(11),
@pass varchar(10)
)
as
select * from Vendedores where venUsuario=@user and venContraseña=@pass
go


create table Facturas(
facNumero char(11) not null,
facFecha date not null,
facCliente char(11) not null,
facValorTotal char(20) not null,
facVendedor char(11) not null,
foreign key (facCliente) references Clientes (cliDocumento),
foreign key (facVendedor) references Vendedores (venUsuario),
constraint PK_Facturas primary key clustered
(
facNumero asc
)with (pad_index = off, statistics_norecompute = off, ignore_dup_key = off, allow_row_locks = on, allow_page_locks = on)on [primary]
)on [primary]

go

--Procedimiento Almacenado Insertar == Facturas

create procedure sp_InsertarFacturas
(
@facNumero char(11),
@facFecha date,
@facCliente char(11),
@facValorTotal char(20),
@facVendedor char(11)
)
as
insert into Facturas (facNumero, facFecha, facCliente, facValorTotal, facVendedor)
values (@facNumero, @facFecha, @facCliente, @facValorTotal, @facVendedor)
go

--Procedimiento Almacenado Consultar == Facturas

create procedure sp_ConsultarFacturas
as
select * from Facturas
go

create table Productos(
proCodigo char(11) not null,
proDescripcion varchar(50) not null,
proValor char(20) not null,
proCantidad char(11) not null,
constraint PK_Productos primary key clustered
(
proCodigo asc
)with (pad_index = off, statistics_norecompute = off, ignore_dup_key = off, allow_row_locks = on, allow_page_locks = on)on [primary]
)on [primary]

go



insert into Productos values ('901','Aceite de Almendras','13098','187')
insert into Productos values ('902','Caléndula','8546','259')
insert into Productos values ('903','Embrion de Pato','18500','456')
insert into Productos values ('904','Lecitina de Soya','12345','300')
insert into Productos values ('905','Omega','34567','1234')
insert into Productos values ('906','Te verde','6789','3456')
insert into Productos values ('907','Valeriana','2871','34')
insert into Productos values ('908','Vitamina C','6547','97')
insert into Productos values ('909','Vitamina E','7439','567')
go

--Procedimiento Almacenado Insertar == Productos

create procedure sp_ConsultarProductos
as
select * from Productos
go

--Procedimiento Almacenado Listar == Productos

create procedure sp_ListarProductos
as
select proCodigo, proDescripcion, proValor from Productos
go

--Procedimiento Almacenado ListarClientes == Clientes

create procedure sp_ListarClientes
as
select cliNombre from Clientes
order by cliNombre asc
go

--Procedimeinto Almacenado ListarInventario == Inventario

create procedure sp_ListarInventario
as
select proDescripcion, proValor, proCantidad from Productos
go


--Procedimiento Almacenar ListaDescripcion == Descripcion

create procedure sp_ListarDescripcion
as
select proDescripcion from Productos
order by proDescripcion asc
go


--Procedimiento Almacenado Insertar == 
create procedure sp_InsertarProductos
(
@proCodigo char(11),
@proDescripcion varchar(50),
@proValor char(20),
@proCantidad char(20)
)
as
insert into Productos(proCodigo, proDescripcion, proValor, proCantidad)
values (@proCodigo, @proDescripcion, @proValor, @proCantidad)
go

--Procedimiento Almacenado Modificar == Producto
create procedure sp_ModificarProductos
@proCodigo char(11),
@proDescripcion varchar(50),
@proValor char(20)
as
update Productos set proCodigo=@proCodigo, proDescripcion=@proDescripcion, proValor=@proValor where proCodigo = @proCodigo
go

--Procedimiento Almacenado Eliminar == Productos

create procedure sp_EliminarProductos
@proDescripcion varchar(50)
as
delete from Productos where proDescripcion=@proDescripcion
go


--Procedimiento Almacenado r == Productos

create table FacturaDetalle(
facNumero char(11) not null,
facProducto char(11) not null,
facCantidad char(11) not null,
foreign key (facNumero) references Facturas (facNumero),
foreign key (facProducto) references Productos (proCodigo)
)

go


create procedure sp_BuscarProducto
@textobuscar varchar(50)
as
	select * from Productos
	where proDescripcion = @textobuscar
go

create procedure spbuscar_producto
@textobuscar varchar(50)
as
	select * from Productos
	where proDescripcion like '%'+@textobuscar+'%'
go

exec sp_ListarDescripcion
exec sp_ListarProductos
exec sp_ListarInventario
exec sp_ListarClientes
exec sp_ModificarProductos '116','Tomillo','2193'
exec sp_EliminarProductos 'Ajo'

