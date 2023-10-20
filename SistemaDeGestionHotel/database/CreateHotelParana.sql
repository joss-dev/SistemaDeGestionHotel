CREATE DATABASE HotelParana;

USE HotelParana;

--AGREGAR FECHA Y HORA DE PAGO
--AGREGAR UN ESTADO EN PAGO
--AGREGAR PRECIO DE HABITACION PACTADO EN REGISTRO

CREATE TABLE Perfil_usuario(
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

CREATE TABLE Estado_habitacion(
    ID_estado INT NOT NULL IDENTITY(1, 1),
	Nomb_estado VARCHAR(50) NOT NULL,
	CONSTRAINT PK_ID_estado PRIMARY KEY (ID_estado)
);

CREATE TABLE Tipo_habitacion(
	ID_tipoHab INT NOT NULL IDENTITY(1, 1),
	Nomb_tipo Varchar(50) NOT NULL,
	CONSTRAINT PK_ID_tipoHab PRIMARY KEY(ID_tipoHab)
);

CREATE TABLE Piso(
    ID_piso INT NOT NULL IDENTITY(1, 1),
	Nro_piso INT NOT NULL,
	CONSTRAINT PK_ID_piso PRIMARY KEY (ID_piso)
);

CREATE TABLE Servicios_adicionales(
    ID_servicioAdic INT NOT NULL IDENTITY(1, 1),
	Nomb_servicio VARCHAR(50) NOT NULL,
	Precio FLOAT NOT NULL,
	Estado INT NOT NULL,
	CONSTRAINT PK_ID_servicioAdic PRIMARY KEY (ID_servicioAdic)
);

CREATE TABLE Ofertas_recargo(
	ID_ofertaRecargo INT NOT NULL IDENTITY(1, 1 ),
	Nomb_ofertaRecargo VARCHAR(100) NOT NULL,
	Fecha_desde DATE NOT NULL,
	Fecha_hasta DATE NOT NULL,
	Estado INT NOT NULL,
	Porcentaje_descuento FLOAT NULL,
	Porcentaje_recargo FLOAT NULL,
	CONSTRAINT PK_ID_ofertaRecargo PRIMARY KEY (ID_ofertaRecargo)
);

CREATE TABLE Tipo_medioPago(
	ID_tipo_medioPago INT NOT NULL IDENTITY(1, 1),
	Nomb_medioPago VARCHAR(100) NOT NULL,
	CONSTRAINT PK_ID_tipo_medioPago PRIMARY KEY(ID_tipo_medioPago)
);

CREATE TABLE Medios_pago(
	ID_medio_pago INT NOT NULL IDENTITY(1, 1),
	Nombre VARCHAR (100) NOT NULL,
	Estado INT NOT NULL,
	ID_tipo_medioPago INT NOT NULL,
	CONSTRAINT PK_ID_medio_pago PRIMARY KEY (ID_medio_pago),
	CONSTRAINT FK_ID_tipo_medioPago FOREIGN KEY(ID_tipo_medioPago) REFERENCES Tipo_medioPago(ID_tipo_medioPago)
);

CREATE TABLE Cliente(
	ID_cliente INT NOT NULL IDENTITY(1, 1),
	Apellido_cliente VARCHAR(100) NOT NULL,
	Nombre_cliente VARCHAR(100) NOT NULL,
	DNI_cliente INT NOT NULL,
	Telefono VARCHAR(15) NOT NULL,	
	CONSTRAINT PK_ID_cliente PRIMARY KEY (ID_cliente),
	CONSTRAINT CK_DNI_cliente CHECK (LEN(DNI_cliente) <=9),
	CONSTRAINT UQ_DNI_cliente UNIQUE (DNI_cliente)
);

CREATE TABLE Habitacion(
	Nro_habitacion INT NOT NULL IDENTITY(1, 1),
	Cantidad_camas INT NOT NULL,
	Precio FLOAT NOT NULL,
	ID_estado INT NOT NULL,
	ID_tipoHab INT NOT NULL,
	ID_piso INT NOT NULL,
	CONSTRAINT PK_Nro_habitacion PRIMARY KEY (Nro_habitacion),
	CONSTRAINT FK_ID_estado FOREIGN KEY (ID_estado) REFERENCES Estado_habitacion(ID_estado),
	CONSTRAINT FK_ID_tipoHab FOREIGN KEY (ID_tipoHab) REFERENCES Tipo_habitacion(ID_tipoHab),
	CONSTRAINT FK_ID_piso FOREIGN KEY (ID_piso) REFERENCES Piso(ID_piso)
);

CREATE TABLE Registro(
	ID_registro INT NOT NULL IDENTITY(1, 1),
	Cantidad_huespedes INT NOT NULL,
	Estado_ocupacion INT NOT NULL,
	Fecha_ingreso DATE NOT NULL,
	Fecha_salida DATE NOT NULL,
	ID_usuario INT NOT NULL,
	Nro_habitacion INT NOT NULL,
	ID_cliente INT NOT NULL,
	CONSTRAINT PK_ID_registro PRIMARY KEY (ID_registro),
	CONSTRAINT FK_ID_usuario FOREIGN KEY (ID_usuario) REFERENCES Usuario(ID_usuario),
	CONSTRAINT FK_Nro_habitacion FOREIGN KEY (Nro_habitacion) REFERENCES Habitacion (Nro_habitacion),
	CONSTRAINT FK_ID_cliente FOREIGN KEY (ID_cliente) REFERENCES Cliente(ID_cliente),
);

CREATE TABLE Detalle_Servicios(
	ID_registro INT NOT NULL,
	ID_servicioAdic INT NOT NULL,
	CONSTRAINT FK_ID_registro FOREIGN KEY (ID_registro) REFERENCES Registro (ID_registro),
	CONSTRAINT FK_ID_servicioAdic FOREIGN KEY(ID_servicioAdic) REFERENCES Servicios_adicionales(ID_servicioAdic)
);

CREATE TABLE Pago(
	ID_pago INT NOT NULL IDENTITY(1,1),
	Monto_pago FLOAT NOT NULL,
	ID_ofertaRecargo INT NULL,
	ID_registro INT NOT NULL,
	ID_medio_pago INT NOT NULL,
	CONSTRAINT PK_ID_pago PRIMARY KEY (ID_pago),
	CONSTRAINT FK_ID_ofertaRecargo FOREIGN KEY (ID_ofertaRecargo) REFERENCES Ofertas_recargo(ID_ofertaRecargo),
	CONSTRAINT FK_ID_registro_pago FOREIGN KEY (ID_registro) REFERENCES Registro (ID_registro),
	CONSTRAINT FK_ID_medio_pago FOREIGN KEY (ID_medio_pago) REFERENCES Medios_pago(ID_medio_pago),
);


INSERT INTO Perfil_usuario(Nombre)
VALUES ('SUPERADMIN');


INSERT INTO Perfil_usuario(Nombre)
VALUES ('ADMIN');


INSERT INTO Perfil_usuario(Nombre)
VALUES ('RECEPCIONISTA');

SELECT * FROM Perfil_usuario;

