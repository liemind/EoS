DELIMITER $$
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