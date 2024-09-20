CREATE DATABASE pruebaE;
GO

USE pruebaE;
GO


CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1), -- Llave primaria con auto-incremento
    Nombre NVARCHAR(100) NOT NULL, -- Nombre del usuario, no permite valores nulos
    Apellido NVARCHAR(100) NOT NULL, -- Apellido del usuario, no permite valores nulos
    DNI NVARCHAR(8) NOT NULL, -- DNI con longitud máxima de 8 caracteres
    CONSTRAINT UC_DNI UNIQUE (DNI) -- El DNI debe ser único
);
GO

insert into Usuarios(Nombre, Apellido, DNI) values
('Debian','Zambrano','87459026');

select * from Usuarios
