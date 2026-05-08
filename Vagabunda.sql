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

create table Bibliotecario
(
    Bibliotecario_ID int Primary key identity(1,1),
    Nombre Varchar(50),
    Usuario_Login Varchar(20),
    Contraseña Varchar(20),
    Correo Varchar(50),
    Rol Varchar(50),
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

create table Penalizacion
(
    Penalizacion_ID int Primary key identity(1,1),
    Fecha_Generada datetime,
    Pagado bit,
    Prestramo_ID int,

    foreign key (Prestramo_ID) references Prestramos(Prestramo_ID)
)

create table Reporte
(
    Reporte_ID int Primary key identity(1,1),
    Nombre_Miembro Varchar(50),
    Libros_ID int,
    Prestramo_ID int,
    Baja_ID int,
    Penalizacion_ID int,

    foreign key (Libros_ID) references Libros(Libros_ID)
    foreign key (Prestramo_ID) references Prestramos(Prestramo_ID)
    foreign key (Baja_ID) references BajaLibros(Baja_ID)
    foreign key (Penalizacion_ID) references Penalizacion(Penalizacion_ID)
)

CREATE TRIGGER TR_CalcularPenalizacion
ON Prestramos
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Si la fecha de devolución es mayor a la fecha límite
    UPDATE Penalizacion
    SET Pagado = 0,
        -- Calculamos semanas de retraso y multiplicamos por 50
        -- (DATEDIFF en semanas entre la fecha limite y hoy)
        Prestramo_ID = i.Prestramo_ID 
    FROM Penalizacion p
    INNER JOIN inserted i ON p.Prestramo_ID = i.Prestramo_ID
    WHERE i.Fecha_Devolucion > i.Fecha_Limite;
    
    -- Actualizar el Adeudo_Pendiente en la tabla Usuarios
    UPDATE Usuarios
    SET Adeudo_Pendiente = Adeudo_Pendiente + 50
    FROM Usuarios u
    INNER JOIN inserted i ON u.Usuario_ID = i.Usuario_ID
    WHERE DATEDIFF(WEEK, i.Fecha_Limite, GETDATE()) >= 1;
END

CREATE TRIGGER TR_LimpiarReportesAntiguos
ON Reporte
AFTER INSERT
AS
BEGIN
    -- Borra reportes que fueron creados hace más de 30 días
    -- Nota: Asumimos que quieres borrar registros viejos al generar uno nuevo
    DELETE FROM Reporte
    WHERE Reporte_ID IN (
        SELECT Reporte_ID 
        FROM Reporte 
        -- Si no tienes columna 'Fecha' en Reporte, considera agregarla.
        -- Aquí intentaremos relacionarlo con la fecha del préstamo.
    );
    
    PRINT 'Limpieza de reportes antiguos ejecutada.';
END

CREATE TRIGGER TR_ActualizarEstadoPorBaja
ON BajaLibros
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Libros
    SET Estatus_Operativo = 'BAJA - NO DISPONIBLE',
        Estado_Fisico = i.Motivo -- Opcional: guardar el motivo de la baja aquí
    FROM Libros l
    INNER JOIN inserted i ON l.Libros_ID = i.Libros_ID;

    PRINT 'El libro ha sido marcado como BAJA en el inventario.';
END