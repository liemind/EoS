DELIMITER $$
DROP PROCEDURE IF EXISTS sp_identificador_modificar $$
CREATE PROCEDURE sp_identificador_modificar
(
	in_id int,
	in_formula Text,
    in_m double
)
BEGIN

	UPDATE identificador
	SET 
		`formula` = in_formula, `m` = in_m WHERE `id` = in_id;

END
$$