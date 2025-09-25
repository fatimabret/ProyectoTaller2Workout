CREATE DATABASE workout;
use workout;

/*DEFINICON DE TABLAS*/
CREATE TABLE ROL
(
  id_rol INT NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  CONSTRAINT PK_rol PRIMARY KEY (id_rol)
);

CREATE TABLE ESTADO
(
  id_estado INT NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  CONSTRAINT PK_estado PRIMARY KEY (id_estado)
);

CREATE TABLE USUARIO
(
  id_usuario INT IDENTITY(1,1) NOT NULL,
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
  id_entrenador INT IDENTITY(1,1) NOT NULL,
  horario_disp VARCHAR(30) NOT NULL,
  detalles VARCHAR(30) NOT NULL,
  dias_disp VARCHAR(30) NOT NULL,
  cupo INT NOT NULL,
  id_usuario INT NOT NULL,
  CONSTRAINT PK_entrenador PRIMARY KEY (id_entrenador),
  CONSTRAINT FK_usuario FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

CREATE TABLE ALUMNO
(
  id_alumno INT IDENTITY(1,1) NOT NULL,
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
  id_membresia INT IDENTITY(1,1) NOT NULL,
  fecha_pago DATE NOT NULL,
  fecha_venc DATE NOT NULL,
  monto FLOAT NOT NULL,
  id_alumno INT NOT NULL,
  id_estado INT NOT NULL,
  CONSTRAINT PK_membresia PRIMARY KEY (id_membresia),
  CONSTRAINT FK_membresia_alumno FOREIGN KEY (id_alumno) REFERENCES ALUMNO(id_alumno),
  CONSTRAINT FK_membresia_estado FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado)
);

CREATE TABLE EJERCICIO
(
  id_ejercicio INT IDENTITY(1,1) NOT NULL,
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
  CONSTRAINT PK_rutina PRIMARY KEY (id_alumno, id_ejercicio),
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
  id_pago INT IDENTITY(1,1) NOT NULL,
  importe FLOAT NOT NULL,
  id_metodo_pago INT NOT NULL,
  id_membresia INT NOT NULL,
  CONSTRAINT PK_pago PRIMARY KEY (id_pago),
  CONSTRAINT FK_pago_metodo_pago FOREIGN KEY (id_metodo_pago) REFERENCES METODO_PAGO(id_metodo_pago),
  CONSTRAINT FK_pago_membresia FOREIGN KEY (id_membresia) REFERENCES MEMBRESIA(id_membresia)
);
/*DEFINICION DE TABLAS*/

/*INSERTS*/

/*ROLES*/
INSERT INTO ROL (id_rol,descripcion) VALUES
(1,'Administrador'),
(2,'Recepcionista'),
(3,'Entrenador');

/*ESTADOS*/
INSERT INTO ESTADO (id_estado, descripcion) VALUES 
(0, 'Inactivo'),
(1, 'Activo')

/*METODOS DE PAGO*/
INSERT INTO METODO_PAGO (id_metodo_pago, tipo, id_estado) VALUES 
(1,'Debito',1),
(2,'Credito',1),
(3,'Transferencia',1);

/*USUARIOS*/
INSERT INTO USUARIO(apellido, nombre, correo, contrasena, dni, id_estado, id_rol) values 
('Gonzalez','Ariel','arielgonzalez@gmail.com','12345',48715624,1,1);

INSERT INTO USUARIO(apellido, nombre, correo, contrasena, dni, id_estado, id_rol) values 
('Bret','Fatima','fatimabret@gmail.com','12345',41234723,1,2);

INSERT INTO USUARIO(apellido, nombre, correo, contrasena, dni, id_estado, id_rol) values 
('Bongiovanni','Iara','bongio22@gmail.com','12345',45953428,1,3);

INSERT INTO USUARIO(apellido, nombre, correo, contrasena, dni, id_estado, id_rol) values 
('Perez','Adrian','adrianperez@gmail.com','12345',47832121,1,3);

/*ENTRENADOR*/
INSERT INTO ENTRENADOR(horario_disp, detalles, dias_disp, cupo, id_usuario) values 
('Mañana (08:00 - 12:00)','Musculacion','Lunes, Miercoles y Jueves',15,3);

INSERT INTO ENTRENADOR(horario_disp, detalles, dias_disp, cupo, id_usuario) values 
('Mañana (08:00 - 12:00)','Musculacion','Martes y Jueves',15,4);

/*ALUMNOS*/
INSERT INTO ALUMNO(dni,nombre,apellido,detalles,genero,correo,id_estado,id_entrenador,fecha_nac)VALUES 
(43782712,'Marcos','Perez','Hernia de disco, Dolor de rodilla','Hombre','marcosgonzalez@gmail.com',1,1,'1995-04-12');

INSERT INTO ALUMNO(dni,nombre,apellido,detalles,genero,correo,id_estado,id_entrenador,fecha_nac)VALUES 
(42735725,'Samantha','Vazquez','Dolor de rodilla','Mujer','samvazquez@gmail.com',1,2,'2000-08-12');

/*MEMBRESIAS*/
INSERT INTO MEMBRESIA(fecha_pago,fecha_venc,monto,id_alumno,id_estado) VALUES
('2025-09-21','2025-10-21',20000,1,1);
INSERT INTO MEMBRESIA(fecha_pago,fecha_venc,monto,id_alumno,id_estado) VALUES
('2025-09-21','2025-10-21',20000,2,1);

/*PAGO*/
INSERT INTO PAGO(importe,id_metodo_pago,id_membresia) VALUES
(20000,2,1);
INSERT INTO PAGO(importe,id_metodo_pago,id_membresia) VALUES
(20000,1,2);

/*EJERCICIOS*/
INSERT INTO EJERCICIO(descripcion,serie,repeticiones,descanso,id_entrenador) VALUES
('Press Banca',3,10,3,1),
('Peso Muerto Rumano',3,10,3,1),
('Sentadilla Trasera',3,8,4,1),
('Fondos en Paralelas',3,10,2,1),
('Pantorrillas con Mancuerna',3,8,2,1);
/*INSERTS*/

/*SELECTS*/
SELECT * FROM USUARIO;
SELECT * FROM ENTRENADOR;
SELECT * FROM ROL;
SELECT * FROM ALUMNO;
SELECT * FROM ESTADO;
SELECT * FROM METODO_PAGO;
SELECT * FROM MEMBRESIA;
SELECT * FROM RUTINA;
SELECT * FROM EJERCICIO;
SELECT * FROM PAGO;
/*SELECTS*/

/*          PROCEDIMIENTOS ALMACENADOS          */
GO
CREATE OR ALTER PROCEDURE SP_CONSULTAR_RUTINA_ALUMNO
    @dni INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        a.dni,
        u.nombre + ' ' + u.apellido AS Entrenador,
        e.horario_disp AS Horario,
        r.dia AS FechaRutina,
        ej.descripcion AS Ejercicio,
        ej.serie AS Series,
        ej.repeticiones AS Repeticiones,
        ej.descanso AS Descanso
    FROM ALUMNO a
    INNER JOIN RUTINA r ON r.id_alumno = a.id_alumno
    INNER JOIN EJERCICIO ej ON ej.id_ejercicio = r.id_ejercicio
    INNER JOIN ENTRENADOR e ON e.id_entrenador = ej.id_entrenador
    INNER JOIN USUARIO u ON e.id_usuario = u.id_usuario
    WHERE a.dni = @dni
    ORDER BY r.dia, ej.descripcion;
END
GO

GO
CREATE OR ALTER PROCEDURE SP_LISTAR_USUARIOS
AS
BEGIN
	SELECT	u.dni,
			u.nombre,
			u.apellido,
			r.descripcion AS 'Rol',
			es.descripcion AS 'Estado'
    FROM USUARIO u
	INNER JOIN ESTADO es ON u.id_estado = es.id_estado
	INNER JOIN ROL r ON u.id_rol = r.id_rol
	ORDER BY r.descripcion ASC ;
END
GO

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
    SELECT a.dni, a.nombre,a.apellido,m.fecha_pago,m.fecha_venc, u.nombre AS 'Entrenador', es.descripcion FROM ALUMNO a 
	INNER JOIN MEMBRESIA m ON a.id_alumno = m.id_alumno
	INNER JOIN ENTRENADOR e ON a.id_entrenador = e.id_entrenador 
	INNER JOIN USUARIO u ON e.id_usuario = u.id_usuario 
	INNER JOIN ESTADO es ON a.id_estado = es.id_estado
	ORDER BY es.descripcion,a.apellido ASC;
END
GO

GO
CREATE PROCEDURE SP_LISTAR_ENTRENADORES
AS
BEGIN
    SELECT 
        u.nombre,
        u.apellido,
        e.horario_disp,
        e.dias_disp,
		e.cupo,
		es.descripcion AS 'Estado'
    FROM ENTRENADOR e
    INNER JOIN USUARIO u ON e.id_usuario = u.id_usuario
	INNER JOIN ESTADO es ON u.id_estado = es.id_estado
    ORDER BY es.descripcion, u.nombre,u.apellido;
END
GO

GO -- para registrar alumno
CREATE PROCEDURE SP_LIST_ENTRENADOR
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        e.id_entrenador,
        u.nombre,
        u.apellido,
        e.horario_disp,
        e.dias_disp,
        e.cupo,
        u.apellido + ' ' + u.nombre + ' - ' + e.horario_disp + ' - ' + e.dias_disp AS InfoCompleta
    FROM ENTRENADOR e
    INNER JOIN USUARIO u ON e.id_usuario = u.id_usuario
    WHERE u.id_estado = 1 
    ORDER BY u.apellido, u.nombre;
END
GO

GO
CREATE PROCEDURE SP_LISTAR_EJERCICIOS
    @id_entrenador INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        e.id_ejercicio,
        e.descripcion,
        e.serie,
        e.repeticiones,
        e.descanso
    FROM EJERCICIO e
    WHERE e.id_entrenador = @id_entrenador
    ORDER BY e.id_ejercicio;
END
GO

GO
CREATE PROCEDURE SP_LISTAR_PAGOS
AS
BEGIN
    SELECT 
		a.apellido,
		a.nombre,
		p.importe AS 'importe',
		mp.tipo,
		m.fecha_pago AS 'pago',
		m.fecha_venc AS 'vencimiento'
    FROM ALUMNO a
    INNER JOIN MEMBRESIA m ON m.id_alumno = a.id_alumno
	INNER JOIN PAGO p ON m.id_membresia = p.id_membresia
	INNER JOIN METODO_PAGO mp ON mp.id_metodo_pago = p.id_metodo_pago
    ORDER BY m.fecha_pago desc;
END
GO

GO
CREATE PROCEDURE SP_LISTAR_ENTRENADOR_POR_ALUMNO
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

GO
CREATE PROCEDURE SP_OBTENER_ID_ENTRENADOR_POR_USUARIO
    @id_usuario INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_entrenador
    FROM ENTRENADOR
    WHERE id_usuario = @id_usuario;
END
GO

GO
CREATE PROCEDURE SP_LISTAR_ALUMNOS_POR_ENTRENADOR
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
	AND a.id_estado = 1
    ORDER BY a.apellido ASC, a.nombre ASC;
END
GO

/*  BUSQUEDAS   */
GO
CREATE OR ALTER PROCEDURE SP_BUSCAR_ALUMNO
    @nombre VARCHAR(30),
    @apellido VARCHAR(30)
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM ALUMNO
        WHERE nombre = @nombre AND apellido = @apellido
    )
    BEGIN
        SELECT id_alumno
        FROM ALUMNO
        WHERE nombre = @nombre AND apellido = @apellido;
    END
    ELSE
    BEGIN
        SELECT -1 AS id_alumno; -- si no existe
    END
END
GO

GO
CREATE OR ALTER PROCEDURE SP_BUSCAR_ALUMNO_DNI
    @dni INT
AS
BEGIN
    SELECT a.dni, 
           a.nombre, 
           a.apellido,
           m.fecha_pago,
           m.fecha_venc, 
           u.nombre AS 'Entrenador', 
           es.descripcion AS 'Estado'
    FROM ALUMNO a
    INNER JOIN MEMBRESIA m ON a.id_alumno = m.id_alumno
    INNER JOIN ENTRENADOR e ON a.id_entrenador = e.id_entrenador 
    INNER JOIN USUARIO u ON e.id_usuario = u.id_usuario 
    INNER JOIN ESTADO es ON a.id_estado = es.id_estado
    WHERE a.dni = @dni;  
END
GO

GO
CREATE OR ALTER PROCEDURE SP_BUSCAR_ENTRENADOR_DNI
    @dni INT
AS
BEGIN
	SELECT	u.nombre,
			u.apellido,
			e.horario_disp,
			e.dias_disp,
			e.cupo,
			es.descripcion AS 'Estado'
    FROM ENTRENADOR e INNER JOIN USUARIO u
	ON e.id_usuario = u.id_usuario
	INNER JOIN ESTADO es ON u.id_estado = es.id_estado
    WHERE u.dni = @dni;  
END
GO

GO
CREATE OR ALTER PROCEDURE SP_BUSCAR_ENTRENADOR
    @nombre VARCHAR(30),
    @apellido VARCHAR(30)
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM USUARIO u
        INNER JOIN ENTRENADOR e ON u.id_usuario = e.id_usuario
        WHERE u.nombre = @nombre AND u.apellido = @apellido
    )
    BEGIN
        SELECT e.id_entrenador
        FROM USUARIO u
        INNER JOIN ENTRENADOR e ON u.id_usuario = e.id_usuario
        WHERE u.nombre = @nombre AND u.apellido = @apellido;
    END
    ELSE
    BEGIN
        SELECT -1 AS id_entrenador; -- si no existe
    END
END
GO

GO
CREATE OR ALTER PROCEDURE SP_BUSCAR_USUARIO_DNI
    @dni INT
AS
BEGIN
	SELECT	u.dni,
			u.nombre,
			u.apellido,
			r.descripcion AS 'Rol',
			es.descripcion AS 'Estado'
    FROM USUARIO u
	INNER JOIN ESTADO es ON u.id_estado = es.id_estado
	INNER JOIN ROL r ON u.id_rol = r.id_rol
    WHERE u.dni = @dni;  
END
GO

GO
CREATE PROCEDURE SP_BUSCAR_PAGOS_DNI
	@dni INT
AS
BEGIN
    SELECT 
		a.apellido,
		a.nombre,
		p.importe AS 'importe',
		mp.tipo,
		m.fecha_pago AS 'pago',
		m.fecha_venc AS 'vencimiento'
    FROM ALUMNO a
    INNER JOIN MEMBRESIA m ON m.id_alumno = a.id_alumno
	INNER JOIN PAGO p ON m.id_membresia = p.id_membresia
	INNER JOIN METODO_PAGO mp ON mp.id_metodo_pago = p.id_metodo_pago
	WHERE a.dni = @dni
    ORDER BY m.fecha_pago desc;
END
GO

GO
CREATE PROCEDURE SP_BUSCAR_MEMBRESIA
    @dni INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_alumno INT;

    -- Buscar alumno
    SELECT @id_alumno = id_alumno
    FROM ALUMNO
    WHERE dni = @dni;

    IF @id_alumno IS NULL
    BEGIN
        RETURN -3; -- Alumno no existe
    END

    -- Buscar membresía vigente
    IF EXISTS (
        SELECT 1
        FROM MEMBRESIA
        WHERE id_alumno = @id_alumno
          AND fecha_venc >= CAST(GETDATE() AS DATE)
          AND id_estado = 1
    )
    BEGIN
        RETURN -2; -- Membresía vigente
    END
    ELSE
    BEGIN
        RETURN -1; -- Membresía no vigente
    END
END
GO

GO
CREATE PROCEDURE SP_OBTENER_MEMBRESIA_POR_DNI
    @dni INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 1 
        m.id_membresia,
        m.fecha_pago,
        m.fecha_venc,
        m.monto,
        CASE 
            WHEN m.fecha_venc >= CAST(GETDATE() AS DATE) THEN 'VIGENTE'
            ELSE 'VENCIDA'
        END AS Estado
    FROM MEMBRESIA m
    INNER JOIN ALUMNO a ON m.id_alumno = a.id_alumno
    WHERE a.dni = @dni
    ORDER BY m.fecha_pago DESC; -- La más reciente
END
GO

GO
CREATE PROCEDURE SP_OBTENER_ULTIMO_PAGO_DNI
    @dni INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 1
        p.id_pago,
        p.importe,
        p.id_metodo_pago,
        p.id_membresia,
        m.fecha_pago,
        m.fecha_venc,
        mp.tipo AS modo_pago,
        CASE 
            WHEN m.fecha_venc >= CAST(GETDATE() AS DATE) THEN 1 -- vigente
            ELSE 0 -- vencida
        END AS id_estado
    FROM ALUMNO a
    INNER JOIN MEMBRESIA m ON m.id_alumno = a.id_alumno
    INNER JOIN PAGO p ON p.id_membresia = m.id_membresia
    INNER JOIN METODO_PAGO mp ON p.id_metodo_pago = mp.id_metodo_pago
    WHERE a.dni = @dni
    ORDER BY m.fecha_pago DESC;
END
GO

/*      INICIAR SESION    */

GO
CREATE OR ALTER PROC SP_INICIAR_SESION
(
    @correo VARCHAR(30),
    @contrasena VARCHAR(30)
)
AS
BEGIN
    IF EXISTS(SELECT 1 FROM USUARIO WHERE correo = @correo AND contrasena = @contrasena)
    BEGIN
        -- Caso estado = 0 → devuelve -2 como id_rol
        IF EXISTS(SELECT 1 FROM USUARIO WHERE correo = @correo AND contrasena = @contrasena AND id_estado = 0)
        BEGIN
            SELECT id_usuario, -2 AS id_rol
            FROM USUARIO
            WHERE correo = @correo AND contrasena = @contrasena AND id_estado = 0;
        END
        ELSE
        BEGIN
            -- Caso estado = 1 → devuelve normal
            SELECT id_usuario, id_rol
            FROM USUARIO
            WHERE correo = @correo AND contrasena = @contrasena AND id_estado = 1;
        END
    END
    ELSE
    BEGIN
        -- Usuario o contraseña incorrectos
        SELECT -1 AS id_usuario, -1 AS id_rol;
    END
END
GO


/*      REGISTROS       */
GO
CREATE PROCEDURE SP_REGISTRAR_RUTINA -- Falla un poquito
    @dni INT,
    @id_ejercicio INT,
    @dia VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_alumno INT;

    -- Buscar alumno
    SELECT @id_alumno = id_alumno
    FROM ALUMNO
    WHERE dni = @dni;

    IF @id_alumno IS NULL
    BEGIN
        RETURN -1; -- Alumno no existe
    END

    -- Insertar rutina
    INSERT INTO RUTINA(dia, id_alumno, id_ejercicio, id_estado)
    VALUES(@dia, @id_alumno, @id_ejercicio, 1);

    RETURN 1; -- éxito
END
GO

GO
CREATE PROCEDURE SP_REGISTRAR_MEMBRESIA
    @dni INT,
    @id_metodo_pago INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_alumno INT;
    DECLARE @id_membresia INT;

    -- Buscar alumno
    SELECT @id_alumno = id_alumno 
    FROM ALUMNO 
    WHERE dni = @dni;

    IF @id_alumno IS NULL
    BEGIN
        RETURN -1; -- Alumno no existe
    END

    -- monto fijo del sistema
    DECLARE @monto FLOAT = 20000;

    -- Insertar membresía
    INSERT INTO MEMBRESIA(fecha_pago, fecha_venc, monto, id_alumno, id_estado)
    VALUES (GETDATE(), DATEADD(DAY, 30, GETDATE()), @monto, @id_alumno, 1);

    SET @id_membresia = SCOPE_IDENTITY();

    -- Insertar pago asociado
    INSERT INTO PAGO(importe, id_metodo_pago, id_membresia)
    VALUES(@monto, @id_metodo_pago, @id_membresia);

    RETURN @id_membresia;
END
GO

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
		SELECT -1 AS id_alumno; -- ya existe
    RETURN;
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
    -- Validaciones
    IF EXISTS(SELECT 1 FROM USUARIO WHERE dni = @dni)
    BEGIN
        RETURN -1; -- Ya existe
    END

    IF NOT EXISTS(SELECT 1 FROM ROL WHERE id_rol = @id_rol)
    BEGIN
        RETURN -2; -- Rol inválido
    END

    -- Inserción
    INSERT INTO dbo.Usuario (apellido, nombre, correo, contrasena, dni, id_estado, id_rol)
    VALUES (@apellido, @nombre, @correo, @contrasena, @dni, @id_estado, @id_rol);

    -- Devuelve el ID generado
    RETURN CONVERT(INT, SCOPE_IDENTITY());
END
GO

GO
CREATE PROCEDURE SP_REGISTRAR_ENTRENADOR
(
    @horario_disp VARCHAR(50), 
    @dias_disp VARCHAR(50), 
    @detalles VARCHAR(30),
    @cupo INT,
    @id_usuario INT
)
AS
BEGIN
    -- Inserción
    INSERT INTO dbo.ENTRENADOR (horario_disp, detalles, dias_disp, cupo, id_usuario)
    VALUES (@horario_disp, @detalles, @dias_disp, @cupo, @id_usuario);

    -- Devuelve el ID generado
    RETURN CAST(SCOPE_IDENTITY() AS INT);
END
GO

GO
CREATE PROCEDURE SP_ELIMINAR_USUARIO(
	@nombre VARCHAR(30),
	@apellido VARCHAR(30)
)
AS
BEGIN
	UPDATE USUARIO
	SET id_estado = 0
	WHERE nombre LIKE @nombre AND apellido LIKE @apellido;
END
GO


GO
CREATE PROCEDURE SP_ACTIVAR_USUARIO(
	@nombre VARCHAR(30),
	@apellido VARCHAR(30)
)
AS
BEGIN
	UPDATE USUARIO
	SET id_estado = 1
	WHERE nombre LIKE @nombre AND apellido LIKE @apellido;
END
GO

GO
CREATE PROCEDURE SP_ELIMINAR_ENTRENADOR(
	@nombre VARCHAR(30),
	@apellido VARCHAR(30)
)
AS
BEGIN
	UPDATE USUARIO
	SET id_estado = 0
	WHERE nombre LIKE @nombre AND apellido LIKE @apellido;
END
GO


GO
CREATE PROCEDURE SP_ACTIVAR_ENTRENADOR(
	@nombre VARCHAR(30),
	@apellido VARCHAR(30)
)
AS
BEGIN
	UPDATE USUARIO
	SET id_estado = 1
	WHERE nombre LIKE @nombre AND apellido LIKE @apellido;
END
GO

GO
CREATE PROCEDURE SP_ELIMINAR_ALUMNO(
	@nombre VARCHAR(30),
	@apellido VARCHAR(30)
)
AS
BEGIN
	UPDATE ALUMNO
	SET id_estado = 0
	WHERE nombre LIKE @nombre AND apellido LIKE @apellido;
END
GO

GO
CREATE PROCEDURE SP_ACTIVAR_ALUMNO(
	@nombre VARCHAR(30),
	@apellido VARCHAR(30)
)
AS
BEGIN
	UPDATE ALUMNO
	SET id_estado = 1
	WHERE nombre LIKE @nombre AND apellido LIKE @apellido;
END
GO



GO
CREATE PROCEDURE SP_MODIFICAR_ALUMNO(
	@id_alumno int,
	@genero VARCHAR(30),
	@detalles VARCHAR(100),
	@id_estado int,
	@id_entrenador int
)
AS
BEGIN
	UPDATE ALUMNO
	SET genero = @genero,
	detalles = @detalles,
	id_estado = @id_estado,
	id_entrenador = @id_entrenador
	WHERE id_alumno = @id_alumno;
END
GO

GO
CREATE PROCEDURE SP_MODIFICAR_ENTRENADOR(
	@id_entrenador int,
	@horario_disp VARCHAR(30),
	@dias_disp VARCHAR(30),
	@detalles VARCHAR(30),
	@cupo int
)
AS
BEGIN
	UPDATE ENTRENADOR
	SET horario_disp = @horario_disp,
	dias_disp = @dias_disp,
	detalles = @detalles,
	cupo = @cupo
	WHERE id_entrenador = @id_entrenador;
END
GO


/*PROCEDIMIENTOS ALMACENADOS*/