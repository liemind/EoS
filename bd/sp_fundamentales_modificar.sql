DELIMITER $$
DROP PROCEDURE IF EXISTS sp_fundamentales_modificar $$
CREATE PROCEDURE sp_fundamentales_modificar
(
	in_id int,
    in_tc_k double,
    in_pc_bar double,
    in_zc double,
    in_w double
)
BEGIN

	UPDATE fundamentales
	SET `tc_k` = in_tc_k, `pc_bar` = in_pc_bar, `zc` = in_zc, `w` = in_w WHERE `id` = in_id;
END
$$