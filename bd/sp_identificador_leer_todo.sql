DELIMITER $$
DROP PROCEDURE IF EXISTS sp_identificador_leer_todo $$
CREATE PROCEDURE sp_identificador_leer_todo()
BEGIN
	SELECT id,compuesto,formula, m
	FROM identificador;
END
$$