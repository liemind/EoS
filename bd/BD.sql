DROP DATABASE IF EXISTS eos;
CREATE DATABASE eos;

USE eos;

CREATE TABLE IF NOT EXISTS eos.identificador(
    id int AUTO_INCREMENT,
    compuesto text,
    formula Text,
    m double,
    PRIMARY KEY(id)
    );

CREATE TABLE IF NOT EXISTS eos.fundamentales(
    id int,
    tc_k double,
    pc_bar double,
    zc double,
    w double,
    PRIMARY KEY(id),
    FOREIGN KEY(id) REFERENCES identificador(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS eos.secundarias(
    id int,
    A double,
    B double,
    C double,
    tmin_k int,
    tmax_k int,
    PRIMARY KEY(id),
    FOREIGN KEY(id) REFERENCES identificador(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS eos.constantes(
    id int,
    A double,
    B double,
    C double,
    D double,
    PRIMARY KEY(id),
    FOREIGN KEY(id) REFERENCES identificador(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS eos.r(
    id int
);

CREATE TABLE IF NOT EXISTS eos.usuario(
    id int AUTO_INCREMENT,
    rut varchar(8),
    nombre text NOT NULL,
    correoElectronico text NOT NULL,
    tipo int NOT NULL,
    password text NOT NULL,
    estado int NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS eos.grupo(
    id int AUTO_INCREMENT,
    llave varchar(9) NOT NULL,
    descripcion text NOT NULL,
    estado int NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS eos.usuariogrupo(
    idUsuario int NOT NULL,
    idGrupo int NOT NULL,
    PRIMARY KEY(idUsuario, idGrupo),
    FOREIGN KEY(idUsuario) REFERENCES usuario(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(idGrupo) REFERENCES grupo(id) ON DELETE CASCADE ON UPDATE CASCADE
);