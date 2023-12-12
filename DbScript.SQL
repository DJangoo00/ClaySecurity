CREATE DATABASE clay_security DEFAULT CHARACTER
SET
    utf8;

USE clay_security

CREATE TABLE
    pais (
        id INT NOT NULL AUTO_INCREMENT,
        nombrePais VARCHAR(50),
        PRIMARY KEY (id)
    );
CREATE TABLE
    departamento (
        id INT NOT NULL AUTO_INCREMENT,
        nombreDepartamento VARCHAR(50),
        idPais INT NOT NULL,
        PRIMARY KEY (id),
        FOREIGN KEY (idPais) REFERENCES pais(id)
    );
CREATE TABLE
    ciudad (
        id INT NOT NULL AUTO_INCREMENT,
        nombreCiudad VARCHAR(50),
        idDepartamento INT NOT NULL,
        PRIMARY KEY (id),
        FOREIGN KEY (idDepartamento) REFERENCES departamento(id)
    );
CREATE TABLE
    estado (
        id INT NOT NULL AUTO_INCREMENT,
        descripcion VARCHAR(50),
        PRIMARY KEY (id)
    );
CREATE TABLE
    turno (
        id INT NOT NULL AUTO_INCREMENT,
        nombreTurno VARCHAR(50),
        horaTurnoI TIME,
        horaTurnoF TIME,
        PRIMARY KEY (id)
    );
CREATE TABLE
    tipoContacto (
        id INT NOT NULL AUTO_INCREMENT,
        descripcion VARCHAR(50),
        PRIMARY KEY (id)
    );
CREATE TABLE
    tipoDireccion (
        id INT NOT NULL AUTO_INCREMENT,
        descripcion VARCHAR(50),
        PRIMARY KEY (id)
    );
CREATE TABLE
    tipoPersona (
        id INT NOT NULL AUTO_INCREMENT,
        descripcion VARCHAR(50),
        PRIMARY KEY (id)
    );
CREATE TABLE
    categoriaPer (
        id INT NOT NULL AUTO_INCREMENT,
        nombreCat VARCHAR(50),
        PRIMARY KEY (id)
    );
CREATE TABLE
    persona (
        id INT NOT NULL AUTO_INCREMENT,
        idPersona VARCHAR(50) UNIQUE,
        nombre VARCHAR(100),
        dateReg DATE,
        idTpersona INT NOT NULL,
        idCat INT NOT NULL,
        idCiudad INT NOT NULL,
        PRIMARY KEY (id),
        FOREIGN KEY (idTpersona) REFERENCES tipoPersona(id),
        FOREIGN KEY (idCat) REFERENCES categoriaPer(id),
        FOREIGN KEY (idCiudad) REFERENCES ciudad(id)
    );
CREATE TABLE
    contactoPer (
        id INT NOT NULL AUTO_INCREMENT,
        descripcion VARCHAR(50) UNIQUE,
        idPersona INT NOT NULL,
        idTContacto INT NOT NULL,
        PRIMARY KEY (id),
        FOREIGN KEY (idPersona) REFERENCES persona(id),
        FOREIGN KEY (idTContacto) REFERENCES tipoContacto(id)
    );
CREATE TABLE
    dirPersona (
        id INT NOT NULL AUTO_INCREMENT,
        direccion VARCHAR(50),
        idPersona INT NOT NULL,
        idTDireccion INT NOT NULL,
        PRIMARY KEY (id),
        FOREIGN KEY (idPersona) REFERENCES persona(id),
        FOREIGN KEY (idTDireccion) REFERENCES tipoDireccion(id)
    );
CREATE TABLE
    contrato (
        id INT NOT NULL AUTO_INCREMENT,
        fechaContrato DATE,
        fechaFin DATE,
        idCliente INT NOT NULL,
        idEmpleado INT NOT NULL,
        idEstado INT NOT NULL,
        PRIMARY KEY (id),
        FOREIGN KEY (idCliente) REFERENCES persona(id),
        FOREIGN KEY (idEmpleado) REFERENCES persona(id),
        FOREIGN KEY (idEstado) REFERENCES estado(id)
    );
CREATE TABLE
    programacion (
        id INT NOT NULL AUTO_INCREMENT,
        idContrato INT NOT NULL,
        idTurno INT NOT NULL,
        idEmpleado INT NOT NULL,
        PRIMARY KEY (id),
        FOREIGN KEY (idContrato) REFERENCES contrato(id),
        FOREIGN KEY (idTurno) REFERENCES turno(id),
        FOREIGN KEY (idEmpleado) REFERENCES persona(id)
    );