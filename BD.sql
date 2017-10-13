Create database eos;

CREATE TABLE eos.identificador(
    id INTEGER AUTO_INCREMENT,
    formula Text,
    m DOUBLE,
    PRIMARY KEY(id)
    );

CREATE TABLE eos.fundamentales(
    id INTEGER AUTO_INCREMENT,
    tc_k DOUBLE,
    pc_bar DOUBLE,
    zc DOUBLE,
    w DOUBLE,
    PRIMARY KEY(id),
    FOREIGN KEY(id) REFERENCES identificador(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE eos.secundarias(
    id INTEGER AUTO_INCREMENT,
    A DOUBLE,
    B DOUBLE,
    C DOUBLE,
    tmin_k INTEGER,
    tmax_k INTEGER,
    PRIMARY KEY(id),
    FOREIGN KEY(id) REFERENCES identificador(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE eos.constantes(
    id INTEGER AUTO_INCREMENT,
    A DOUBLE,
    B DOUBLE,
    C DOUBLE,
    D DOUBLE,
    PRIMARY KEY(id),
    FOREIGN KEY(id) REFERENCES identificador(id) ON DELETE CASCADE ON UPDATE CASCADE
);