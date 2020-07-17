DELIMITER $$
DROP PROCEDURE IF EXISTS sp_constantes_crear $$
CREATE PROCEDURE sp_constantes_crear
(
    in_id int,
    in_A double,
    in_B double,
    in_C double,
    in_D double
)
BEGIN
	INSERT INTO constantes(id, A,B,C,D)
	VALUES (in_id, in_A, in_B, in_C, in_D);
END
$$

DROP PROCEDURE IF EXISTS sp_constantes_eliminar $$
CREATE PROCEDURE sp_constantes_eliminar
(
	in_id int
)
BEGIN
	DELETE FROM constantes
	WHERE id = in_id;

END
$$

DROP PROCEDURE IF EXISTS sp_constantes_leer_todo $$
CREATE PROCEDURE sp_constantes_leer_todo()
BEGIN
	SELECT id,A,B,C,D
	FROM constantes;
END
$$

DROP PROCEDURE IF EXISTS sp_constantes_modificar $$
CREATE PROCEDURE sp_constantes_modificar
(
	in_id int,
    in_A double,
    in_B double,
    in_C double,
    in_D double
)
BEGIN
	UPDATE constantes
	SET `A` = in_A, `B` = in_B, `C` = in_C, `D` = in_D WHERE `id` = in_id;
END
$$

/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_constantes   $$
CREATE PROCEDURE sp_leer_constantes  
(
	in_id int
)
BEGIN
	SELECT A,B,C,D
	FROM constantes   
	WHERE id = in_id;
END
$$