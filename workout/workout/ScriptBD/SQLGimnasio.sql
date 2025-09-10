CREATE DATABASE workout;
use workout;
CREATE TABLE ESTADO
(
  id_estado INT   NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  PRIMARY KEY (id_estado)
);

CREATE TABLE USUARIO
(   
  id_usuario INT IDENTITY(1,1) NOT NULL,
  dni INT NOT NULL,
  apellido VARCHAR(30) NOT NULL,
  nombre VARCHAR(30) NOT NULL,
  fecha_nac DATE NOT NULL,
  correo VARCHAR(50) NOT NULL,
  contrasena VARCHAR(150) NULL,
  id_estado INT NOT NULL,
  PRIMARY KEY (id_usuario),
  FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado)
);

CREATE TABLE ALUMNO
(
  id_alumno INT IDENTITY(1,1) NOT NULL,
  detalles VARCHAR(100) NOT NULL,
  genero VARCHAR(30) NOT NULL,
  id_usuario INT NOT NULL,
  PRIMARY KEY (id_alumno),
  FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

CREATE TABLE MEMBRESIA
(
  id_membresia INT NOT NULL,
  fecha_pago DATE NOT NULL,
  fecha_venc DATE NOT NULL,
  monto FLOAT NOT NULL,
  id_alumno INT NOT NULL,
  id_estado INT NOT NULL,
  PRIMARY KEY (id_membresia),
  FOREIGN KEY (id_alumno) REFERENCES ALUMNO(id_alumno),
  FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado)
);

CREATE TABLE ENTRENADOR
(
  id_entrenador INT NOT NULL,
  horario_disp DATE NOT NULL,
  detalles VARCHAR(30) NOT NULL,
  dias_disp DATE NOT NULL,
  cupo INT NOT NULL,
  id_usuario INT NOT NULL,
  PRIMARY KEY (id_entrenador),
  FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

CREATE TABLE EJERCICIO
(
  id_ejercicio INT NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  serie INT NOT NULL,
  repeticiones INT NOT NULL,
  descanso INT NOT NULL,
  id_entrenador INT NOT NULL,
  PRIMARY KEY (id_ejercicio),
  FOREIGN KEY (id_entrenador) REFERENCES ENTRENADOR(id_entrenador)
);

CREATE TABLE RUTINA
(
  dia VARCHAR(30) NOT NULL,
  id_alumno INT NOT NULL,
  id_ejercicio INT NOT NULL,
  id_estado INT NOT NULL,
  PRIMARY KEY (id_alumno, id_ejercicio),
  FOREIGN KEY (id_alumno) REFERENCES ALUMNO(id_alumno),
  FOREIGN KEY (id_ejercicio) REFERENCES EJERCICIO(id_ejercicio),
  FOREIGN KEY (id_estado) REFERENCES ESTADO(id_estado)
);

CREATE TABLE ROL
(
  id_rol INT NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  id_usuario INT NOT NULL,
  PRIMARY KEY (id_rol),
  FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

CREATE TABLE RECEPCIONISTA
(
  id_recepcionista INT NOT NULL,
  id_usuario INT NOT NULL,
  PRIMARY KEY (id_recepcionista),
  FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

CREATE TABLE ADMINISTRADOR
(
  id_administrador INT NOT NULL,
  id_usuario INT NOT NULL,
  PRIMARY KEY (id_administrador),
  FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

CREATE TABLE METODO_PAGO
(
  id_metodo_pago INT NOT NULL,
  tipo VARCHAR(30) NOT NULL,
  import FLOAT NOT NULL,
  PRIMARY KEY (id_metodo_pago)
);

CREATE TABLE PAGO
(
  id_pago INT NOT NULL,
  total FLOAT NOT NULL,
  id_metodo_pago INT NOT NULL,
  id_membresia INT NOT NULL,
  PRIMARY KEY (id_pago),
  FOREIGN KEY (id_metodo_pago) REFERENCES METODO_PAGO(id_metodo_pago),
  FOREIGN KEY (id_membresia) REFERENCES MEMBRESIA(id_membresia)
);


INSERT INTO ESTADO (id_estado, descripcion) VALUES 
(0, 'Usuario inactivo'),
(1, 'Usuario activo'),
(2, 'Usuario suspendido');


/*PROCEDIMIENTOS ALMACENADOS*/

CREATE PROC SP_LISTARESTADOS
AS
BEGIN
    SELECT id_estado, descripcion FROM ESTADO;
END

/* REGISTRO DE ALUMNO */

GO
CREATE PROC SP_REGISTRARALUMNO
(
@genero varchar (30),
@detalles varchar(100),
@id_usuario int
)
AS
BEGIN
    INSERT INTO dbo.Alumno (detalles, genero, id_usuario) 
    VALUES (@detalles, @genero, @id_usuario)
END
GO
/* Registro de Usuario */

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



SELECT * FROM alumno
SELECT * FROM usuario


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