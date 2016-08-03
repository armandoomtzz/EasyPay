/*
Nombre script: dbEasyPayESC
Descripcion: Creacion del script de la base de datos
Version: 1.0

Historia de modificacion: IS       Fecha                     Descripcion
                          AGMM     14 de Junio del 2016      Se creo el script inicial
						  AGMM	   18 de Julio del 2016      Se añadio el nobre de la base de datos, asi como la tabla "Administradores" y "Usuarios"
                          AGMM     03 de Julio del 2016      Se creo el script final para la DB, esperando indicaciones del profesor
*/

------------------------------------------------------------------------------------------------------------------------------------------------------
/**********************                                  CREACION DE BASE DE DATOS Y USO DE LA MISMA                           **********************/
------------------------------------------------------------------------------------------------------------------------------------------------------
--Usuario de prueba, Numero de Empleado=123, Usuario=armando, Password=123
--Crear base de datos
create database dbEasyPayESC
use dbEasyPayESC
go

------------------------------------------------------------------------------------------------------------------------------------------------------
/**********************                                         CREACION DE LAS TABLAS A USAR                                  **********************/
------------------------------------------------------------------------------------------------------------------------------------------------------
--Crear tabla Administradores
create table Administradores
(
Nombre varchar(100) not null,
PassAdmin varchar(100) not null,
Rango varchar(20) not null,
)

--Crear tabla Usuarios
create table Usuarios
(
NoEmpleado int not null,
Usuario varchar(100) not null,
Contrasena varchar(100) not null,
Fecha varchar(100) not null,
Nombre varchar(100) not null,
)

--Crear tabla Entradas
create table Entradas
(
NoEmpleado int not null,
FechaHoy datetime not null,
)

--Crear tabla Productos
Create table Productos
(
CodigoBarras varchar (20) not null,
Descripcion varchar(50) not null,
Precio decimal(5,2) not null,
Categoria varchar(40) not null,
Proveedor nvarchar(40) not null,
Fecha nvarchar(50) not null,
Volumen int not null,
FecVencimiento nvarchar(50) not null,
Primary key (CodigoBarras)
)

--Crear tabla Venta
create table Ventas
(
Numero int primary key identity,
CodigoBarras varchar (20) not null,
Descripcion varchar(50) not null,
Precio decimal(5,2) not null,
)

--Crear tabla Subtotal
create table Subtotal
(
Subtotal decimal(5,2) not null,
)

--Crear tabla TotalProductos
create table TotalProductos
(
TotalProductos int not null,
)

--Crear tabla Total
create table Total
(
Cantidad decimal(5,2),
Pagado decimal(5,2),
Fecha datetime,
Cambio decimal(5,2),
)

--crear tabla TotalCorte
create table TotalCorte
(
Cantidad decimal(5,2),
Pagado decimal(5,2),
Fecha datetime,
Cambio decimal(5,2),
)

--Crear tabla TotalCorteMostrar
create table TotalCorteMostrar
(
Total decimal(5,2),
)

------------------------------------------------------------------------------------------------------------------------------------------------------
/**********************                                    REGISTROS INDISPENSABLES PARA EL SISTEMA                            **********************/
------------------------------------------------------------------------------------------------------------------------------------------------------
--Agregar un nuevo administrador
insert into Administradores(Nombre, PassAdmin, Rango) values ('EasyPay', 'ep_admin', 'Creador')

------------------------------------------------------------------------------------------------------------------------------------------------------
/**********************                                     VERIFICACION DE TABLAS Y DATOS EN ELLAS                            **********************/
------------------------------------------------------------------------------------------------------------------------------------------------------
--Verificar tablas con datos
select * from Administradores
select * from Usuarios
select * from Entradas
select * from Productos
select * from Ventas
select * from Subtotal
select * from TotalProductos
select * from Total
select * from TotalCorte
select * from TotalCorteMostrar

------------------------------------------------------------------------------------------------------------------------------------------------------
/**********************                                       ELIMINACION DE REGISTROS DE LAS TABLAS                           **********************/
------------------------------------------------------------------------------------------------------------------------------------------------------
truncate table Ventas
truncate table Subtotal
truncate table TotalProductos
truncate table Total
truncate table TotalCorte
truncate table TotalCorteMostrar
truncate table Usuarios
truncate table Entradas 
truncate table Productos