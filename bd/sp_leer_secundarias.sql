/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_secundarias   $$
CREATE PROCEDURE sp_leer_secundarias  
(
	in_id int INTEGER
)
BEGIN
	SELECT A,B,C,tmin_k,tmax_k
	FROM secundarias   
	WHERE id = in_id;
END
$$