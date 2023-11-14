USE HotelParana;

INSERT INTO Servicios_adicionales(Nomb_servicio, Precio, Estado) 
VALUES  ('Wifi', 5000, 1),
		('Estacionamiento', 2000, 1),
		('Desayuno', 2000, 1),
		('Cena', 9000, 1),
		('Lavanderia', 4000, 1),
		('Gimnasio', 5000, 1),
		('Conserjería', 5000, 1);


INSERT INTO Ofertas_recargo(Nomb_ofertaRecargo, Fecha_desde, Fecha_hasta, Estado, Porcentaje_descuento, Porcentaje_recargo)
VALUES	('Oferta - Verano 2024', '2023-11-01', '2024-02-29', 1, 8, 0),
		('Oferta - Invierno 2023', '2023-05-01', '2023-08-31', 1, 4, 0),
		('Recargo - Tarjetas', '2023-01-01', '2023-12-31', 1, 0, 2)


INSERT INTO Cliente(Apellido_cliente, Nombre_cliente, DNI_cliente, Estado, Telefono)
VALUES  ('Fernandez' , 'Carlos', 11111111, 1, 3794567890),
		('Garcia' , 'Alicia', 22222222, 1, 3794123443),
		('Romero' , 'Lisana', 33333333, 1, 3794113789),
		('Caballero' , 'Sofia', 44444444, 1, 3794678934),
		('Enriquez' , 'Oriana', 55555555, 1, 3794007865),
		('Galarza' , 'Agustina', 66666666, 1, 3794546789),
		('Zalazar' , 'Victoria', 77777777, 1, 3794113388),
		('Acosta' , 'Ramona', 88888888, 1, 3794438476),
		('Cardozo' , 'Jose', 99999999, 1, 3794639043),
		('Perez', 'Juan', 12345678, 1, 3794001234),
		('Lopez', 'Maria', 23456789, 1, 3794012345),
		('Gonzalez', 'Pedro', 34567890, 1, 3794023456),
		('Rodriguez', 'Laura', 45678901, 1, 3794034567),
		('Martinez', 'Ana', 56789012, 1, 3794045678),
		('Hernandez', 'Pablo', 67890123, 1, 3794056789),
		('Luna', 'Carla', 78901234, 1, 3794067890),
		('Torres', 'Diego', 89012345, 1, 3794078901),
		('Ruiz', 'Sara', 90123456, 1, 3794089012),
		('Ramirez', 'Miguel', 10234567, 1, 3794090123);

INSERT INTO Habitacion(Nro_habitacion, Cantidad_camas, Precio, ID_estado, ID_tipoHab, ID_piso)
VALUES  (101, 1, 26000, 1, 1, 1),
		(102, 1, 26000, 1, 1, 1),
		(103, 2, 35000, 1, 2, 1),
		(104, 1, 26000, 1, 1, 1),
		(105, 2, 35000, 1, 2, 1),
		(106, 2, 35000, 1, 2, 1),
		(107, 2, 35000, 1, 2, 1),
		(108, 3, 46000, 1, 3, 1),
		(109, 3, 46000, 1, 3, 1),

		(201, 1, 26000, 1, 1, 2),
		(202, 1, 26000, 1, 1, 2),
		(203, 2, 35000, 1, 2, 2),
		(204, 1, 26000, 1, 1, 2),
		(205, 2, 35000, 1, 2, 2),
		(206, 2, 35000, 1, 2, 2),
		(207, 2, 35000, 1, 2, 2),
		(208, 3, 46000, 1, 3, 2),
		(209, 3, 46000, 1, 3, 2),

		(301, 1, 26000, 1, 1, 3),
		(302, 1, 26000, 1, 1, 3),
		(303, 2, 35000, 1, 2, 3),
		(304, 1, 26000, 1, 1, 3),
		(305, 2, 35000, 1, 2, 3),
		(306, 2, 35000, 1, 2, 3),
		(307, 2, 35000, 1, 2, 3),
		(308, 3, 46000, 1, 3, 3),
		(309, 3, 46000, 1, 3, 3);


INSERT INTO Consulta(Asunto, Mensaje, Fecha_mensaje, Estado, ID_usuario) 
VALUES  ('Cambio de contraseña', 'Quiero cambiar mi contraseña de usuario', '2023-04-01', 0, 3),
		('Cambio de usuario', 'Quiero cambiar mi nombre de usuario', '2023-11-01', 1, 3);


INSERT INTO Registro(Cantidad_huespedes, Precio_HabPactado, Estado_ocupacion, Fecha_ingreso, Fecha_salida, ID_usuario, Nro_habitacion, ID_cliente)
VALUES  --estadías
		(2, 35000, 1, '2023-11-10', '2023-11-18', 3, 3, 1),
		(1, 26000, 1, '2023-11-10', '2023-11-17', 3, 1, 2),
		(2, 35000, 1, '2023-11-11', '2023-11-20', 3, 11, 3),
		(3, 46000, 1, '2023-11-15', '2023-11-21', 3, 26, 4),
		(1, 26000, 1, '2023-11-14', '2023-11-23', 3, 2, 5),
		(2, 35000, 1, '2023-11-15', '2023-11-25', 3, 16, 6),
		--reservas
		(2, 35000, 0, '2023-11-18', '2023-11-28', 3, 21, 7),
		(1, 26000, 0, '2023-11-19', '2023-11-27', 3, 19, 8),
		(2, 35000, 0, '2023-11-18', '2023-11-20', 3, 23, 9),
		(3, 46000, 0, '2023-11-20', '2023-11-22', 3, 18, 10),
		(1, 26000, 0, '2023-11-19', '2023-11-23', 3, 20, 11),
		(2, 35000, 0, '2023-11-20', '2023-11-25', 3, 12, 12),
		
		--facturadas
		(3, 46000, 2, '2023-11-10', '2023-11-14', 3, 26, 17),
		(1, 26000, 2, '2023-11-11', '2023-11-13', 3, 2, 18),
		(2, 35000, 2, '2023-11-10', '2023-11-12', 3, 16, 14),
		
		--canceladas
		(1, 26000, 0, '2023-11-01', '2023-11-12', 3, 20, 19),
		(2, 35000, 0, '2023-11-04', '2023-11-15', 3, 12, 20)


INSERT INTO DetalleServicios(ID_registro, ID_servicioAdic) 
VALUES (1, 1),
		(1, 3),
		(3, 1),
		(3, 2),
		(3, 4),
		(5, 2),
		(6, 3),
		(8, 1),
		(8, 2),
		(8, 3),
		(8, 4),
		(10, 1),
		(13, 3),
		(13, 1),
		(14, 3),
		(14, 2)


INSERT INTO Pago (Monto_pago, Fecha_horaPago, Estado_pago, ID_ofertaRecargo, ID_registro, ID_medio_pago)
VALUES 
		(53000, '2023-11-14 12:00:00', 1, NULL, 13, 1),
		(30000, '2023-11-13 12:30:00', 1, 2, 14, 2),
		(35000, '2023-11-12 13:00:00', 1, 2, 15, 3);
