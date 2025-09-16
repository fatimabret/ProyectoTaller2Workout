CREATE DATABASE workout;
use workout;

CREATE TABLE ESTADO
(
  id_estado INT NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  CONSTRAINT PK_estado PRIMARY KEY (id_estado)
);

CREATE TABLE ALUMNO
(
  id_alumno INT NOT NULL,
  detalles VARCHAR(100) NOT NULL,
  genero VARCHAR(30) NOT NULL,
  apellido VARCHAR(30) NOT NULL,
  nombre VARCHAR(30) NOT NULL,
  correo VARCHAR(30) NOT NULL,
  fecha_nac DATE NOT NULL,
  dni INT NOT NULL,
  id_estado INT NOT NULL,
  id_entrenador INT NOT NULL,
  CONSTRAINT PK_alumno PRIMARY KEY (id_alumno),
  CONSTRAINT FK_alumno_estado FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado),
  CONSTRAINT FK_ALUMNO_ENTRENADOR FOREIGN KEY (id_entrenador) REFERENCES ENTRENADOR(id_entrenador)
);

CREATE TABLE MEMBRESIA
(
  id_membresia INT NOT NULL,
  fecha_pago DATE NOT NULL,
  fecha_venc DATE NOT NULL,
  monto FLOAT NOT NULL,
  id_alumno INT NOT NULL,
  id_estado INT NOT NULL,
  CONSTRAINT PK_membresia PRIMARY KEY (id_membresia),
  CONSTRAINT FK_membresia_alumno FOREIGN KEY (id_alumno) REFERENCES ALUMNO(id_alumno),
  CONSTRAINT FK_membresia_estado FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado)
);

CREATE TABLE ROL
(
  id_rol INT NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  CONSTRAINT PK_rol PRIMARY KEY (id_rol)
);

CREATE TABLE USUARIO
(
  id_usuario INT NOT NULL,
  apellido VARCHAR(30) NOT NULL,
  nombre VARCHAR(30) NOT NULL,
  correo VARCHAR(50) NOT NULL,
  contrasena VARCHAR(150) NOT NULL,
  dni INT NOT NULL,
  id_estado INT NOT NULL,
  id_rol INT NOT NULL,
  CONSTRAINT PK_usuario PRIMARY KEY (id_usuario),
  CONSTRAINT FK_usuario_estado FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado),
  CONSTRAINT FK_usuario_rol FOREIGN KEY (id_rol) REFERENCES ROL(id_rol)
);

CREATE TABLE ENTRENADOR
(
  id_entrenador INT NOT NULL,
  horario_disp VARCHAR(30) NOT NULL,
  detalles VARCHAR(30) NOT NULL,
  dias_disp VARCHAR(30) NOT NULL,
  cupo INT NOT NULL,
  id_usuario INT NOT NULL,
  CONSTRAINT PK_entrenador PRIMARY KEY (id_entrenador),
  CONSTRAINT FK_entrenador_usuario FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

CREATE TABLE EJERCICIO
(
  id_ejercicio INT NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  serie INT NOT NULL,
  repeticiones INT NOT NULL,
  descanso INT NOT NULL,
  id_entrenador INT NOT NULL,
  CONSTRAINT PK_ejercicio PRIMARY KEY (id_ejercicio),
  CONSTRAINT FK_ejercicio_entrenador FOREIGN KEY (id_entrenador) REFERENCES ENTRENADOR(id_entrenador)
);

CREATE TABLE RUTINA
(
  dia VARCHAR(30) NOT NULL,
  id_alumno INT NOT NULL,
  id_ejercicio INT NOT NULL,
  id_estado INT NOT NULL,
  CONSTRAINT PK_ejercicio PRIMARY KEY (id_alumno, id_ejercicio),
  CONSTRAINT FK_rutina_alumno FOREIGN KEY (id_alumno) REFERENCES ALUMNO(id_alumno),
  CONSTRAINT FK_rutina_ejercicio FOREIGN KEY (id_ejercicio) REFERENCES EJERCICIO(id_ejercicio),
  CONSTRAINT FK_rutina_estado FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado)
);

CREATE TABLE METODO_PAGO
(
  id_metodo_pago INT NOT NULL,
  tipo VARCHAR(30) NOT NULL,
  id_estado INT NOT NULL,
  CONSTRAINT PK_metodo_pago PRIMARY KEY (id_metodo_pago),
  CONSTRAINT FK_metodo_pago_estado FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado)
);

CREATE TABLE PAGO
(
  id_pago INT NOT NULL,
  importe FLOAT NOT NULL,
  id_metodo_pago INT NOT NULL,
  id_membresia INT NOT NULL,
  CONSTRAINT PK_pago PRIMARY KEY (id_pago),
  CONSTRAINT FK_pago_metodo_pago FOREIGN KEY (id_metodo_pago) REFERENCES METODO_PAGO(id_metodo_pago),
  CONSTRAINT FK_pago_membresia FOREIGN KEY (id_membresia) REFERENCES MEMBRESIA(id_membresia)
);

/*INSERTS*/
INSERT INTO ROL (id_rol,descripcion) VALUES
(1,'Administrador'),
(2,'Recepcionista'),
(3,'Entrenador');
select * from ROL;

INSERT INTO ESTADO (id_estado, descripcion) VALUES 
(0, 'Inactivo'),
(1, 'Activo'),
(2, 'Suspendido');
select * from ESTADO;

INSERT INTO METODO_PAGO (id_metodo_pago, tipo, id_estado) VALUES 
(1,'Debito',1),
(2,'Credito',1),
(3,'Transferencia',1);
select * from METODO_PAGO;

INSERT INTO USUARIO(id_usuario,apellido, nombre, correo, contrasena, dni, id_estado, id_rol) values 
(1,'Gonzalez','Ariel','arielgonzalez@gmail.com','12345',48715624,1,1);
INSERT INTO USUARIO(id_usuario,apellido, nombre, correo, contrasena, dni, id_estado, id_rol) values 
(2,'Bret','Fatima','fatimabret@gmail.com','12345',41234723,1,2);
INSERT INTO USUARIO(id_usuario,apellido, nombre, correo, contrasena, dni, id_estado, id_rol) values 
(3,'Bongiovanni','Iara','bongio22@gmail.com','12345',45953428,1,3);
SELECT * FROM USUARIO;


/*          PROCEDIMIENTOS ALMACENADOS          */

/* Listados simples */
GO
CREATE PROC SP_LISTAR_ESTADOS
AS
BEGIN
    SELECT id_estado, descripcion FROM ESTADO;
END
GO

GO
CREATE PROC SP_LISTAR_ALUMNOS
AS
BEGIN
    SELECT * FROM ALUMNO ORDER BY ALUMNO.apellido ASC;
END
GO

GO
CREATE PROCEDURE SP_LISTAR_ENTRENADORES
    @id_alumno INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        e.id_entrenador,
        u.nombre,
        u.apellido,
        e.horario_disp,
        e.dias_disp,
        e.cupo
    FROM ENTRENADOR e
    INNER JOIN USUARIO u ON e.id_usuario = u.id_usuario
    WHERE e.id_alumno = @id_alumno;
END
GO

/*      Listados entre tablas       */
/*  ENTRENADOR ASIGNADO A UN ALUMNO EN ESPECIFICO  */
GO
CREATE OR ALTER PROCEDURE SP_LISTAR_ENTRENADOR_POR_ALUMNO
    @id_alumno INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        u.nombre,
        u.apellido
    FROM ENTRENADOR e
    INNER JOIN USUARIO u ON e.id_usuario = u.id_usuario
    INNER JOIN ALUMNO a ON a.id_entrenador = e.id_entrenador
    WHERE a.id_alumno = @id_alumno;
END
GO

/*  LISTADO DE ALUMNOS DE UN ENTRENADOR  */
GO
CREATE OR ALTER PROCEDURE SP_LISTAR_ALUMNOS_POR_ENTRENADOR
    @id_entrenador INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        a.dni,
        a.nombre,
        a.apellido,
        a.genero,
        a.detalles
    FROM ALUMNO a
    INNER JOIN ESTADO e ON a.id_estado = e.id_estado
    WHERE a.id_entrenador = @id_entrenador
    ORDER BY a.apellido ASC, a.nombre ASC;
END
GO

GO
CREATE PROC SP_INICIAR_SESION
(
    @correo VARCHAR(30),
    @contrasena VARCHAR(30)
)
AS
BEGIN
    IF EXISTS(SELECT 1 FROM USUARIO WHERE correo = @correo AND contrasena = @contrasena)
    BEGIN
        SELECT id_usuario, id_rol
        FROM USUARIO
        WHERE correo = @correo AND contrasena = @contrasena;
    END
    ELSE
    BEGIN
        SELECT -1 AS id_usuario, -1 AS id_rol;
    END
END
GO


/*      REGISTROS       */
GO
CREATE PROC SP_REGISTRAR_ALUMNO
(
	@nombre VARCHAR(30),
	@apellido VARCHAR(30),
	@correo VARCHAR(30),
	@detalles VARCHAR(100),
	@genero VARCHAR(30),
	@fecha_nac DATE,
	@dni INT,
	@id_estado INT,
    @id_entrenador INT
)
AS
BEGIN
	IF EXISTS(SELECT dni FROM ALUMNO WHERE alumno.dni = @dni)
	BEGIN
		RETURN -1;
	END

    INSERT INTO dbo.Alumno (nombre, apellido, dni, fecha_nac, genero, correo, detalles,id_estado, id_entrenador) 
    VALUES (@nombre,@apellido,@dni,@fecha_nac,@genero,@correo,@detalles,@id_estado, @id_entrenador);

	RETURN CAST(SCOPE_IDENTITY() AS INT);
END
GO

GO
CREATE PROCEDURE SP_REGISTRAR_USUARIO
(
  @apellido VARCHAR(30),
  @nombre VARCHAR(30),
  @correo VARCHAR(50),
  @contrasena VARCHAR(150),
  @dni INT,
  @id_estado INT,
  @id_rol INT
)
AS
BEGIN
	
	IF EXISTS(SELECT dni FROM USUARIO WHERE USUARIO.dni = @dni)
	BEGIN
		RETURN -1;
	END

    INSERT INTO dbo.Usuario ( apellido, nombre, correo, contrasena, dni, id_estado, id_rol)
    VALUES (@apellido, @nombre, @correo, @contrasena, @dni, @id_estado, @id_rol);

    -- Devolvemos el id_usuario insertado para confirmación
    RETURN CAST(SCOPE_IDENTITY() AS INT);
END
GO

GO
CREATE PROCEDURE SP_REGISTRAR_ENTRENADOR
(
	@horario_disp VARCHAR(50), 
	@dias_disp VARCHAR(50), 
	@detalles VARCHAR(30)
)
AS
BEGIN
    INSERT INTO dbo.ENTRENADOR (horario_disp, detalles, dias_disp) VALUES(@horario_disp,@detalles,@dias_disp);
END
GO

/*SELECTS*/
SELECT * FROM alumno;
SELECT * FROM estado;
SELECT * FROM metodo_pago;
SELECT * FROM usuario;

/* Registro de Usuario */
/*
GO
CREATE PROCEDURE SP_REGISTRAR
(
@dni int,
@nombre varchar(30),
@apellido varchar(30),
@contrasena varchar(150),
@id_estado int,
@fecha_nac Date,
@correo varchar(50)
)
AS
BEGIN
  

    -- Buscar el id_estado correspondiente al tipo
    SELECT @id_estado = id_estado
    FROM ESTADO
    WHERE id_estado = @id_estado

    INSERT INTO dbo.Usuario(dni,nombre,apellido, contrasena, id_estado,fecha_nac,correo) 
    VALUES (@dni,@nombre, @apellido,@contrasena,@id_estado,@fecha_nac,@correo)

     SELECT SCOPE_IDENTITY() AS id_usuario;
END
GO
*/



/* ELIMINAR DE MENU
GO
CREATE PROC SP_ELIMINARMENU
(
@id_menu int,
@Respuesta bit output,
@Mensaje varchar(200) output
)
AS
BEGIN
    SET @Respuesta = 1

    -- Verificar si el menu ya está eliminado (activo = 0)
    IF EXISTS (SELECT * FROM dbo.Menu WHERE id_menu = @id_menu AND activo = 0)
    BEGIN
        SET @Respuesta = 0;
        SET @Mensaje = 'El Menú ya se encuentra eliminado.';
        RETURN;
    END

    -- Para validar que no exista una asociacion del menu en otras tablas
    IF NOT EXISTS(SELECT * FROM dbo.menu menu 
					INNER JOIN dbo.producto producto 
					ON producto.Id_Menu = menu.Id_Menu
					WHERE menu.Id_Menu = @id_menu)
		BEGIN
			UPDATE dbo.Menu SET activo = 0
			WHERE Id_Menu = @id_menu
	
			SET @Mensaje = 'Menú eliminada exitosamente.'
			SET @Respuesta = 1
		END
	ELSE
		BEGIN
			SET @Respuesta = 0
			SET @Mensaje = 'Menú asociada a información en productos.'
		END
END 
GO
*/