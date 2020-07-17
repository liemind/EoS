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

DROP PROCEDURE IF EXISTS sp_fundamentales_eliminar $$
CREATE PROCEDURE sp_fundamentales_eliminar
(
	in_id int
)
BEGIN
	DELETE FROM fundamentales
	WHERE id = in_id;

END
$$

DROP PROCEDURE IF EXISTS sp_fundamentales_leer_todo $$
CREATE PROCEDURE sp_fundamentales_leer_todo()
BEGIN
	SELECT id,tc_k,pc_bar,zc,w
	FROM fundamentales;
END
$$

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

/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_fundamentales $$
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