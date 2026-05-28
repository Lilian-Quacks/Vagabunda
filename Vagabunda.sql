CREATE DATABASE Vagabunda
GO

USE Vagabunda
GO

CREATE TABLE Usuarios
(
    Usuario_ID int Primary key identity(1,1),
    Nombre Varchar(50) not null,
    Direccion Varchar(150) not null,
    Telefono Varchar(10) not null,
    Email Varchar(255) not null,
    Adeudo_Pendiente money,
    Prestamos_Activos Bit,
)
GO

CREATE TABLE Bibliotecario
(
    Bibliotecario_ID int Primary key identity(1,1),
    Nombre Varchar(50),
    Usuario_Login Varchar(20),
    Contraseña Varchar(20),
    Correo Varchar(50),
    Rol Varchar(50),
)
GO

CREATE TABLE Libros
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
GO

CREATE TABLE BajaLibros
(
    Baja_ID int Primary key identity(1,1),
    Fecha datetime,
    Motivo Varchar(100),
    Libros_ID int,
    Bibliotecario_ID int,
    foreign key (Libros_ID) references Libros(Libros_ID),
    foreign key (Bibliotecario_ID) references Bibliotecario(Bibliotecario_ID)
)
GO

CREATE TABLE Prestamos
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
GO

CREATE TABLE Penalizacion
(
    Penalizacion_ID int Primary key identity(1,1),
    Fecha_Generada datetime,
    Monto money,
    Pagado bit,
    Prestamo_ID int,
    foreign key (Prestamo_ID) references Prestamos(Prestamo_ID)
)
GO

CREATE TABLE Reporte
(
    Reporte_ID int Primary key identity(1,1),
    Fecha Datetime,
    Nombre_Miembro Varchar(50),
    Libros_ID int,
    Prestamo_ID int,
    Baja_ID int,
    Penalizacion_ID int,
    Fecha_Registro DATETIME DEFAULT GETDATE(),
    foreign key (Libros_ID) references Libros(Libros_ID),
    foreign key (Prestamo_ID) references Prestamos(Prestamo_ID),
    foreign key (Baja_ID) references BajaLibros(Baja_ID),
    foreign key (Penalizacion_ID) references Penalizacion(Penalizacion_ID)
)
GO

CREATE TRIGGER TR_VerificarVencimiento
ON Prestamos
AFTER UPDATE, INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Prestamos
    SET Estatus = 'Retrasado'
    FROM Prestamos p
    INNER JOIN inserted insV on p.Prestamo_ID = insV.Prestamo_ID
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
    
    IF EXISTS (SELECT 1 FROM inserted WHERE Fecha_Devolucion IS NULL AND GETDATE() > Fecha_Limite)
    BEGIN
        UPDATE Usuarios
        SET Adeudo_Pendiente = ISNULL(u.Adeudo_Pendiente, 0) + 
            (CASE 
                WHEN DATEDIFF(DAY, insP.Fecha_Limite, GETDATE()) >= 7 
                THEN (DATEDIFF(DAY, insP.Fecha_Limite, GETDATE()) / 7) * 50 
                ELSE 0 
             END)
        FROM Usuarios u
        INNER JOIN inserted insP ON u.Usuario_ID = insP.Usuario_ID
        WHERE insP.Fecha_Devolucion IS NULL;
    END
END;
GO

CREATE TRIGGER TR_LimpiarReportesAntiguos
ON Reporte
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Reporte 
    WHERE Fecha_Registro < DATEADD(DAY, -30, GETDATE());
END
GO

CREATE TRIGGER TR_BajaAutomaticaLibro
ON BajaLibros
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Libros
    SET Estatus_Operativo = 'BAJA',
        Estado_Fisico = insB.Motivo
    FROM Libros l
    INNER JOIN inserted insB ON l.Libros_ID = insB.Libros_ID;
END
GO

INSERT INTO Bibliotecario
(
    Nombre,
    Usuario_Login,
    Contraseña,
    Correo,
    Rol
)
VALUES
(
    'Administrador',
    'admin',
    '1234',
    'admin@vagabunda.com',
    'Administrador'
)
GO