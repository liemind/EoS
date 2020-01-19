DELIMITER $$
/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_constantes   $$
CREATE PROCEDURE sp_leer_constantes  
(
	in_id int
)
BEGIN
	SELECT A,B,C,D
	FROM constantes   
	WHERE id = in_id;
END
$$