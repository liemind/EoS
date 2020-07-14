DELIMITER $$

/*Leer todo*/
DROP PROCEDURE IF EXISTS sp_leertodas_noticia   $$
CREATE PROCEDURE sp_leertodas_noticia  ()
BEGIN
    SELECT id, titulo, cuerpo, fecha, autor
    FROM noticia ORDER BY fecha DESC;
END
$$


/*Leer las ultimas cinco*/
DROP PROCEDURE IF EXISTS sp_leercinco_noticia   $$
CREATE PROCEDURE sp_leercinco_noticia  ()
BEGIN
    SELECT id, titulo, cuerpo, fecha, autor
    FROM noticia ORDER BY fecha DESC LIMIT 5;
END
$$


/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_noticia  $$
CREATE PROCEDURE sp_leer_noticia  
(
    in_id INTEGER
)
BEGIN
    SELECT id, titulo, cuerpo, fecha, autor
    FROM noticia   
    WHERE id = in_id;
END
$$


DROP PROCEDURE IF EXISTS sp_crear_noticia $$
CREATE PROCEDURE sp_crear_noticia
(
    in_titulo TEXT,
    in_cuerpo TEXT,
    in_fecha DATETIME,
    in_autor INTEGER
)
BEGIN
    INSERT INTO noticia(titulo, cuerpo, fecha, autor)
    VALUES (in_titulo, in_cuerpo, in_fecha, in_autor);
END
$$


/*Modificar*/
DROP PROCEDURE IF EXISTS sp_modificar_noticia $$
CREATE PROCEDURE sp_modificar_noticia
(
    in_id INTEGER,
    in_titulo TEXT,
    in_cuerpo TEXT
)
BEGIN
    UPDATE Usuario
    SET titulo = in_titulo, cuerpo = in_cuerpo
    WHERE id = in_id;
END
$$

/**Eliminar**/
DROP PROCEDURE IF EXISTS sp_eliminar_noticia $$
CREATE PROCEDURE sp_eliminar_noticia
(
	in_id int
)
BEGIN

	DELETE FROM noticia
	WHERE id = in_id;

END
$$

