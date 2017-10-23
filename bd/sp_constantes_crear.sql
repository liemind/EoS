DELIMITER $$
DROP PROCEDURE IF EXISTS sp_constantes_crear $$
CREATE PROCEDURE sp_constantes_crear
(
    in_id int,
    in_A double,
    in_B double,
    in_C double,
    in_D double
)
BEGIN

	INSERT INTO constantes(id, A,B,C,D)
	VALUES (in_id, in_A, in_B, in_C, in_D);

END
$$