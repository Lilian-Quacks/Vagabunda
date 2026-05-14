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
    Prestamos_Activos Bool,
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

    foreign key (Libros_ID) references Libros(Libros_ID),
    foreign key (Bibliotecario_ID) references Bibliotecario(Bibliotecario_ID)
)

create table Prestamos
(
    Prestamo_ID int Primary key identity(1,1),
    Fecha_Salida datetime,
    Fecha_Limite datetime,
    Fecha_Devolucion datetime,
    Penalizacion_Generada Varchar(100),
    Estatus Varchar (20),
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
	Fecha_Registro DATETIME DEFAULT GETDATE(),

    foreign key (Libros_ID) references Libros(Libros_ID),
    foreign key (Prestramo_ID) references Prestramos(Prestramo_ID),
    foreign key (Baja_ID) references BajaLibros(Baja_ID),
    foreign key (Penalizacion_ID) references Penalizacion(Penalizacion_ID)
)



CREATE TRIGGER TR_VerificarVencimiento
ON Prestamos
AFTER UPDATE, INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Si el libro no se ha devuelto y la fecha actual superó la límite
    UPDATE Prestamos
    SET Estatus = 'Retrasado'
    FROM Prestamos p
    INNER JOIN inserted i ON p.Prestamo_ID = i.Prestamo_ID
    WHERE p.Fecha_Devolucion IS NULL 
      AND GETDATE() > p.Fecha_Limite;
END;
GO


CREATE TRIGGER TR_GenerarPenalizacionSemanal
ON Prestamos
AFTER UPDATE 
AS
BEGIN
    SET NOCOUNT ON;

    -- Solo actualiza si el libro no se ha devuelto y ya pasó la fecha límite
    IF EXISTS (SELECT 1 FROM inserted WHERE Fecha_Devolucion IS NULL AND GETDATE() > Fecha_Limite)
    BEGIN
        UPDATE Usuarios
        SET Adeudo_Pendiente = ISNULL(Adeudo_Pendiente, 0) + 
            (CASE 
                -- Si ya pasó más de una semana de la fecha límite
                WHEN DATEDIFF(DAY, i.Fecha_Limite, GETDATE()) >= 7 
                THEN (DATEDIFF(DAY, i.Fecha_Limite, GETDATE()) / 7) * 50 
                ELSE 0 
             END)
        FROM Usuarios u
        INNER JOIN inserted i ON u.Usuario_ID = i.Usuario_ID
        WHERE i.Fecha_Devolucion IS NULL;
    END
END;
GO

CREATE TRIGGER TR_LimpiarReportesAntiguos
ON Reporte
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Borra registros con más de 30 días de antigüedad
    DELETE FROM Reporte 
    WHERE Fecha_Registro < DATEADD(DAY, -30, GETDATE());
END

CREATE TRIGGER TR_BajaAutomaticaLibro
ON BajaLibros
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Cambia el estado en la tabla Libros automáticamente
    UPDATE Libros
    SET Estatus_Operativo = 'BAJA',
        Estado_Fisico = i.Motivo
    FROM Libros l
    INNER JOIN inserted i ON l.Libros_ID = i.Libros_ID;
END

