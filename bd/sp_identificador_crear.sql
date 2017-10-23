DELIMITER $$
DROP PROCEDURE IF EXISTS sp_identificador_crear $$
CREATE PROCEDURE sp_identificador_crear
(
    in_formula text,
    in_m double
)
BEGIN

	INSERT INTO identificador(formula, m)
	VALUES (in_formula, in_m);

END
$$