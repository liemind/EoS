DELIMITER $$
DROP PROCEDURE IF EXISTS sp_fundamentales_crear $$
CREATE PROCEDURE sp_fundamentales_crear
(
    in_id int,
    in_tc_k double,
    in_pc_bar double,
    in_zc double,
    in_w double
 )
BEGIN

	INSERT INTO fundamentales(id,tc_k,pc_bar,zc,w)
	VALUES (in_id, in_tc_k, in_pc_bar, in_zc, in_w);

END
$$