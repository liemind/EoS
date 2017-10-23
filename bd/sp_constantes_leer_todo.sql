DELIMITER $$
DROP PROCEDURE IF EXISTS sp_constantes_leer_todo $$
CREATE PROCEDURE sp_constantes_leer_todo()
BEGIN
	SELECT id,A,B,C,D
	FROM constantes;
END
$$