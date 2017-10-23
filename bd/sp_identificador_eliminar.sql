DELIMITER $$
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