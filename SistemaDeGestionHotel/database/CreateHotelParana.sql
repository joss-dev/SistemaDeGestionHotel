CREATE DATABASE HotelParana;


CREATE TABLE Perfil_usuario (
	ID_perfil_usuario INT NOT NULL IDENTITY(1, 1),
	Nombre VARCHAR(100) NOT NULL,
	CONSTRAINT PK_ID_perfil_usuario PRIMARY KEY(ID_perfil_usuario)
);


CREATE TABLE Usuario(
	ID_usuario INT NOT NULL IDENTITY(1, 1),
	Nombre VARCHAR(100) NOT NULL,
	Apellido VARCHAR(100) NOT NULL,
	DNI INT NOT NULL,
	Correo_electronico VARCHAR(200) NOT NULL, 
	Direccion VARCHAR(120) NOT NULL,
	Nombre_usuario VARCHAR(100) NOT NULL,
	Contraseña VARCHAR(200) NOT NULL,
	Foto_perfil VARCHAR(300) NOT NULL,
	ID_perfil_usuario INT,
	CONSTRAINT UQ_Nombre_usuario UNIQUE(Nombre_usuario),
	CONSTRAINT UQ_DNI UNIQUE(DNI),
	CONSTRAINT UQ_Correo_electronico UNIQUE(Correo_electronico),
	CONSTRAINT FK_Id_perfil_usuario FOREIGN KEY(ID_perfil_usuario) REFERENCES Perfil_usuario(ID_perfil_usuario),
	CONSTRAINT PK_ID_usuario PRIMARY KEY(ID_usuario)
);



INSERT INTO Perfil_usuario(Nombre)
VALUES ('SUPERADMIN');


INSERT INTO Perfil_usuario(Nombre)
VALUES ('ADMIN');


INSERT INTO Perfil_usuario(Nombre)
VALUES ('RECEPCIONISTA');


SELECT * FROM Perfil_usuario;