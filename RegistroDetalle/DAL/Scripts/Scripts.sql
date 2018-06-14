CREATE DATABASE PersonasDb
GO
USE PersonasDb
GO
CREATE TABLE Personas
(
	PersonaId int primary key identity(1,1),
	Comentarios varchar(100),
	Nombres varchar(30),
	Fecha DateTime,
	Telefono varchar(13),
	Cedula varchar(13),
	Direccion varchar(max)
);
