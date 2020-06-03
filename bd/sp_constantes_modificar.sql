DELIMITER $$
DROP PROCEDURE IF EXISTS sp_constantes_modificar $$
CREATE PROCEDURE sp_constantes_modificar
(
	in_id int,
    in_A double,
    in_B double,
    in_C double,
    in_D double
)
BEGIN
	UPDATE constantes
	SET `A` = in_A, `B` = in_B, `C` = in_C, `D` = in_D WHERE `id` = in_id;
END
$$