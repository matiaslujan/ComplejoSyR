create database ComplejoSolYRio
go
use ComplejoSolYRio 

create table Clientes 
(
Id int primary key identity,
Nombre varchar (60),
Domicilio varchar (60),
Provincia varchar (30),
Correo varchar (60),
Telefono varchar (20),
Vehiculo varchar (30),
Patente varchar (10)

)

create table Modalidades 
(
Id int primary key identity,
Nombre varchar (60),
Tipo varchar (20)
)

create table Alojamientos 
(
Id int primary key identity,
Numero int ,
Capacidad int,
IdModalidad int,
Sector varchar (20)
)

create table Reservas
(
Id int primary key identity,
IdCliente int,
FIngreso date,
FEgreso date,
FReserva date,
ImpDia decimal(10,2),
Cancelada bit,
CantDias int,
CantPersonas int,
Descripcion varchar(200),
ImpTotal decimal(10,2)

)
create table AlojamientoDeReserva
(
Id int primary key identity,
IdReserva int,
IdAlojamiento int 
)

create table Servicios
(
Id int primary key identity,
IdReserva int,
Importe decimal (10,2),
Fecha date,
Descripcion varchar (60) 
)
create table Pagos
(
Id int primary key identity,
IdReserva int,
Importe decimal (10,2),
Fecha date,
Descripcion varchar (60) 
)

