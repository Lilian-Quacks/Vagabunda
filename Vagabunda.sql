create database Vagabunda

use Vagabunda

create table Usuarios
(
    Usuario_ID int Primary key identity(1,1),
    Nombre Varchar(50)not null,
    Direccion Varchar(150)not null,
    Telefono Varchar(10) not null,
    Email Varchar(255) not null,
    Adeudo_Pendiente money,
    Prestramo_Activos int
)

create table Prestramos
(
    Prestramo_ID int Primary key identity(1,1),
    Fecha_Salida datetime,
    Fecha_Limite datetime,
    Fecha_Devolucion datetime,
    Penalizacion_Generada Varchar(100),
    Estatus Varchar,
    Usuario_ID int,
    Libros_ID int,
    Bibliotecario_ID int,

    foreign key (Usuario_ID) references Usuarios(Usuario_ID),
    foreign key (Libros_ID) references Libros(Libros_ID),
    foreign key (Bibliotecario_ID) references Bibliotecario(Bibliotecario_ID)
)

create table Libros
(
    Libros_ID int Primary key identity(1,1),
    Titulo Varchar(100),
    Autor Varchar(50),
    Editorial Varchar(50),
    Fecha_Publicacion datetime,
    ISBN Varchar(13),
    Estado_Fisico Varchar(20),
    Estatus_Operativo Varchar(50),
    Contador_Prestamo int,
    Bibliotecario_ID int,

    foreign key (Bibliotecario_ID) references Bibliotecario(Bibliotecario_ID)
)

create table Bibliotecario
(
    Bibliotecario_ID int Primary key identity(1,1),
    Nombre Varchar(50),
    Usuario_Login Varchar(20),
    Contraseña Varchar(20),
    Correo Varchar(50),
    Rol Varchar(50),
)

create table Reporte
(
    Reporte_ID int Primary key identity(1,1),
    Nombre_Miembro Varchar(50),
    Libros_ID int,
    Prestramo_ID int,
    Baja_ID int,
    Penalizacion_ID int,

    foreign key (Bibliotecario_ID) references Libros(Libros_ID)
    foreign key (Prestramo_ID) references Prestramos(Prestramo_ID)
    foreign key (Baja_ID) references BajaLibros(Baja_ID)
    foreign key (Penalizacion_ID) references Penalizacion(Penalizacion_ID)
)

create table BajaLibros
(
    Baja_ID int Primary key identity(1,1),
    Fecha datetime,
    Motivo Varchar(100),
    Libros_ID int,
    Bibliotecario_ID int,

    foreign key (Libros_ID) references Libros(Libros_ID)
    foreign key (Bibliotecario_ID) references Bibliotecario(Bibliotecario_ID)
)

create table Penalizacion
(
    Penalizacion_ID int Primary key identity(1,1),
    Fecha_Generada datetime,
    Pagado bit,
    Prestramo_ID int,

    foreign key (Prestramo_ID) references Prestramos(Prestramo_ID)
)

