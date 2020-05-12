DELIMITER $$
/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_fundamentales   $$
CREATE PROCEDURE sp_leer_fundamentales  
(
	in_id int
)
BEGIN
	SELECT tc_k,pc_bar,zc,w
	FROM fundamentales   
	WHERE id = in_id;
END
$$