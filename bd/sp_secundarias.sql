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

DROP PROCEDURE IF EXISTS sp_secundarias_eliminar $$
CREATE PROCEDURE sp_secundarias_eliminar
(
	in_id int
)
BEGIN
	DELETE FROM secundarias
	WHERE id = in_id;
END
$$

DROP PROCEDURE IF EXISTS sp_secundarias_leer_todo $$
CREATE PROCEDURE sp_secundarias_leer_todo()
BEGIN
	SELECT id,A,B,C,tmin_k,tmax_k
	FROM secundarias;
END
$$

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
	SET `A` = in_A, `B` = in_B, `C` = in_C, `tmin_k` = in_tmin_k, `tmax_k` = in_tmax_k WHERE `id` = in_id;
END
$$

/*Leer uno*/
DROP PROCEDURE IF EXISTS sp_leer_secundarias   $$
CREATE PROCEDURE sp_leer_secundarias  
(
	in_id int
)
BEGIN
	SELECT A,B,C,tmin_k,tmax_k
	FROM secundarias   
	WHERE id = in_id;
END
$$