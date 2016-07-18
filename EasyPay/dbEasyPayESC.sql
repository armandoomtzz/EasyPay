/*
Nombre script: dbEasyPayESC
Descripcion: Creacion del script de la base de datos
Version: 1.0

Historia de modificacion: IS       Fecha                     Descripcion
                          AGMM     14 de Junio del 2016      Se creo el script inicial
						  AGMM	   18 de Julio del 2016      Se añadio el nobre de la base de datos, asi como la tabla "Administradores" y "Usuarios"
*/


--Crear base de datos
create database dbEasyPayESC
use dbEasyPayESC
go

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
Contraseña varchar(100) not null,
Fecha varchar(100) not null,
)

--Agregar un nuevo administrador
insert into Administradores(Nombre, PassAdmin, Rango) values ('EasyPay', 'ep_admin', 'Creador')

--Verificar tablas con datos
select * from Administradores
select * from Usuarios