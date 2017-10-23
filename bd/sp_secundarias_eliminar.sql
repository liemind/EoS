DELIMITER $$
DROP PROCEDURE IF EXISTS sp_secundarias_eliminar $$
CREATE PROCEDURE sp_secundarias_eliminar
(
	in_id int
)
BEGIN

	DELETE FROM secundarias
	WHERE id = in_id;

END
$$