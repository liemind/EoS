DELIMITER $$
DROP PROCEDURE IF EXISTS sp_secundarias_leer_todo $$
CREATE PROCEDURE sp_secundarias_leer_todo()
BEGIN
	SELECT id,A,B,C,tmin_k,tmax_k
	FROM secundarias;
END
$$