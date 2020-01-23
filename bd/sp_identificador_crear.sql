DELIMITER $$
DROP PROCEDURE IF EXISTS sp_identificador_crear $$
CREATE PROCEDURE sp_identificador_crear
(
	in_compuesto text,
    in_formula text,
    in_m double
)
BEGIN

	INSERT INTO identificador(compuesto, formula, m)
	VALUES (in_compuesto, in_formula, in_m);

END
$$