DELIMITER $$
DROP PROCEDURE IF EXISTS sp_identificador_crear $$
CREATE PROCEDURE sp_identificador_crear
(
	in_compuesto text,
    in_formula text,
    in_m double
)
BEGIN

	INSERT INTO identificador(compuesto, formula, m)
	VALUES (in_compuesto, in_formula, in_m);

END
$$

DROP PROCEDURE IF EXISTS sp_identificador_eliminar $$
CREATE PROCEDURE sp_identificador_eliminar
(
	in_id int
)
BEGIN

	DELETE FROM identificador
	WHERE id = in_id;

END
$$

DROP PROCEDURE IF EXISTS sp_identificador_leer_todo $$
CREATE PROCEDURE sp_identificador_leer_todo()
BEGIN
	SELECT id,compuesto,formula, m
	FROM identificador;
END
$$

DROP PROCEDURE IF EXISTS sp_identificador_modificar $$
CREATE PROCEDURE sp_identificador_modificar
(
	in_id int,
	in_compuesto text,
	in_formula Text,
    in_m double
)
BEGIN
	UPDATE identificador
	SET `formula` = in_formula, `compuesto` = in_compuesto, `m` = in_m WHERE `id` = in_id;
END
$$

/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_identificador   $$
CREATE PROCEDURE sp_leer_identificador  
(
	in_id int
)
BEGIN
	SELECT compuesto, formula, m
	FROM identificador   
	WHERE id = in_id;
END
$$