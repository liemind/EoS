DELIMITER $$

/*Leer todo*/
DROP PROCEDURE IF EXISTS sp_leertodos_log   $$
CREATE PROCEDURE sp_leertodos_log  ()
BEGIN
    SELECT id, fecha, autor, accion
    FROM log ORDER BY fecha DESC;
END
$$

DROP PROCEDURE IF EXISTS sp_crear_log $$
CREATE PROCEDURE sp_crear_log
(
    in_fecha DATETIME,
    in_autor INTEGER,
    in_accion TEXT
)
BEGIN
    INSERT INTO log(fecha, autor, accion)
    VALUES (in_fecha, in_autor, in_accion);
END
$$