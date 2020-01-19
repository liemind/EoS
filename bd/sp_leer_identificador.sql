/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_identificador   $$
CREATE PROCEDURE sp_leer_identificador  
(
	in_id int INTEGER
)
BEGIN
	SELECT compuesto, formula, m
	FROM identificador   
	WHERE id = in_id;
END
$$