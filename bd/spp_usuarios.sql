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

