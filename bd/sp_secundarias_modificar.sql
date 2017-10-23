DELIMITER $$
DROP PROCEDURE IF EXISTS sp_secundarias_modificar $$
CREATE PROCEDURE sp_secundarias_modificar
(
	in_id int,
    in_A double,
    in_B double,
    in_C double,
    in_tmin_k int,
    in_tmax_k int
)
BEGIN

	UPDATE secundarias
	SET 
		`A` = in_A, `B` = in_B, `C` = in_C, `tmin_k` = in_tmin_k, `tmax_k` = in_tmax_k WHERE `id` = in_id;

END
$$