DELIMITER $$
DROP PROCEDURE IF EXISTS sp_fundamentales_leer_todo $$
CREATE PROCEDURE sp_fundamentales_leer_todo()
BEGIN
	SELECT id,tc_k,pc_bar,zc,w
	FROM fundamentales;
END
$$