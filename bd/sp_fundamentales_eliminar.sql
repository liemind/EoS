DELIMITER $$
DROP PROCEDURE IF EXISTS sp_fundamentales_eliminar $$
CREATE PROCEDURE sp_fundamentales_eliminar
(
	in_id int
)
BEGIN

	DELETE FROM fundamentales
	WHERE id = in_id;

END
$$