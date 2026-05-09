create database Vagabunda

use Vagabunda

create table Usuarios
(
    Usuario_ID Primary key identity(1,1),
    Nombre Varchar(50)not null,
    Direccion Varchar(150)not null,
    Telefono Varchar(10) not null,
    Email Varchar(255) not null,
    Adeudo_Pendiente money,
    Prestramo_Activos int
)

CREATE TABLE Prestramo
(
    Prestramo_ID Primary key identity(1,1),
    Fecha_Salida datetime,
    Fecha_Limite datetime,
    Fecha_Devolucion datetime,
    Penalizacion_Generada Varchar(100),
    Estatus Varchar,
    Usuario_ID int,
    Libros_ID int,
    Bibliotecario_ID int
)