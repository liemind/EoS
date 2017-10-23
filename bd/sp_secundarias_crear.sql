DELIMITER $$
DROP PROCEDURE IF EXISTS sp_secundarias_crear $$
CREATE PROCEDURE sp_secundarias_crear
(
    in_id int,
    in_A double,
    in_B double,
    in_C double,
    in_tmin_k int,
    in_tmax_k int
)
BEGIN

	INSERT INTO secundarias(id,A,B,C,tmin_k,tmax_k)
	VALUES (in_id, in_A, in_B, in_C, in_tmin_k,in_tmax_k);

END
$$