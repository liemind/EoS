DELIMITER $$

/*Leer todo*/
DROP PROCEDURE IF EXISTS sp_leertodas_usuario   $$
CREATE PROCEDURE sp_leertodas_usuario  ()
BEGIN
    SELECT id, rut, nombre, correoElectronico, tipo, estado
    FROM usuario;
END
$$

/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_usuario   $$
CREATE PROCEDURE sp_leer_usuario  
(
    in_rut INTEGER
)
BEGIN
    SELECT id, rut, nombre, correoElectronico, tipo, estado
    FROM usuario   
    WHERE rut = in_rut;
END
$$

/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_usuario_id   $$
CREATE PROCEDURE sp_leer_usuario_id
(
    in_id INTEGER
)
BEGIN
    SELECT id, rut, nombre, correoElectronico, tipo, estado
    FROM usuario   
    WHERE id = in_id;
END
$$

/*Habilitar y deshabilitar competencia*/
DROP PROCEDURE IF EXISTS sp_habilitar_deshabilitar_usuario $$
CREATE PROCEDURE sp_habilitar_deshabilitar_usuario
(
    in_rut INTEGER,
    in_estado TINYINT
    
)
BEGIN
    UPDATE Usuario
    SET estado = in_estado
    WHERE rut = in_rut;
END
$$


/*Verificar Pass*/
DROP PROCEDURE IF EXISTS sp_verificar_pass $$
CREATE PROCEDURE sp_verificar_pass
(
    in_rut INTEGER,
    in_pass TEXT
)
BEGIN
    Select usuario.password
    FROM Usuario
    WHERE usuario.rut = in_rut AND usuario.password = in_pass;
END
$$

/*Modificar*/
DROP PROCEDURE IF EXISTS sp_modificar_usuario $$
CREATE PROCEDURE sp_modificar_usuario
(
    in_rut varchar(9),
    in_nombre TEXT,
    in_correoElectronico TEXT,
    in_tipo INTEGER,
    in_matricula INTEGER
)
BEGIN
    UPDATE Usuario
    SET nombre = in_nombre, correoelectronico = in_correoElectronico, tipo = in_tipo, matricula = in_matricula
    WHERE rut = in_rut;
END
$$

/*cambiar pass*/
DROP PROCEDURE IF EXISTS sp_cambiar_pass_usuario $$
CREATE PROCEDURE sp_cambiar_pass_usuario
(
    in_rut INTEGER,
    in_password TEXT
    
)
BEGIN
    UPDATE usuario
    SET password = in_password
    WHERE rut = in_rut;
END
$$

/*Verificar Pass*/
DROP PROCEDURE IF EXISTS sp_verificar_pass $$
CREATE PROCEDURE sp_verificar_pass
(
    in_rut INTEGER,
    in_pass TEXT
)
BEGIN
    Select usuario.password
    FROM Usuario
    WHERE usuario.rut = in_rut AND usuario.password = in_pass;
END
$$