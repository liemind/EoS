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
    id int AUTO_INCREMENT,
    
);