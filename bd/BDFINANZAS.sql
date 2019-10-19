-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2018-11-04 04:48:41.151

-- tables
-- Table: Administrador

create database bdFinanzas

use bdFinanzas

-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2018-11-21 01:51:17.606

-- tables
-- Table: Administrador
CREATE TABLE Administrador (
    idUsuario int  NOT NULL,
    CONSTRAINT Administrador_pk PRIMARY KEY  (idUsuario)
);

-- Table: Banco
CREATE TABLE Banco (
    idBanco int identity NOT NULL,
    idUsuario int  NOT NULL,
    NombreBanco nvarchar(20)  NOT NULL,
    TEA float(7)  NOT NULL,
    SeguroRiesgo float(7)  NOT NULL,
    PorRecompa float(7)  NOT NULL,
    costesNotariales float(7)  NOT NULL,
    costesRegistrales float(7)  NOT NULL,
    Tasacion float(7)  NOT NULL,
    comEstudio float(7)  NOT NULL,
    comActivacion float(7)  NULL,
    comPeriodica float(7)  NOT NULL,
    PorsegRiesgo float(7)  NOT NULL,
    ks float(7)  NOT NULL,
    wacc float(7)  NOT NULL,
    CONSTRAINT Banco_pk PRIMARY KEY  (idBanco)
);

-- Table: Banco_Promocion
CREATE TABLE Banco_Promocion (
    Banco_idBanco int identity NOT NULL,
    Promocion_idPromocion int  NOT NULL,
    carro_idCarro int  NOT NULL,
    CONSTRAINT Banco_Promocion_pk PRIMARY KEY  (Banco_idBanco,Promocion_idPromocion,carro_idCarro)
);

-- Table: Cliente
CREATE TABLE Cliente (
    idUsuario int  NOT NULL,
    CONSTRAINT Cliente_pk PRIMARY KEY  (idUsuario)
);

-- Table: Frecuencia
CREATE TABLE Frecuencia (
    idFrecuencia int identity NOT NULL,
    NNombre varchar(20)  NOT NULL,
    cantidadDias int  NOT NULL,
    CONSTRAINT Frecuencia_pk PRIMARY KEY  (idFrecuencia)
);

-- Table: Marca
CREATE TABLE Marca (
    idMarca int identity NOT NULL,
    nMarca varchar(30)  NOT NULL,
    CONSTRAINT Marca_pk PRIMARY KEY  (idMarca)
);

-- Table: PlazoGracia
CREATE TABLE PlazoGracia (
    idPlazoGracia int identity NOT NULL,
    NNombre varchar(25)  NOT NULL,
    CONSTRAINT PlazoGracia_pk PRIMARY KEY  (idPlazoGracia)
);

-- Table: Promocion
CREATE TABLE Promocion (
    idPromocion int identity NOT NULL,
    fechaInicio date  NOT NULL,
    fechaFin date  NOT NULL,
    CONSTRAINT Promocion_pk PRIMARY KEY  (idPromocion)
);

-- Table: Usuario
CREATE TABLE Usuario (
    idDNI int identity NOT NULL,
    Email nvarchar(20)  NOT NULL,
    password nvarchar(16)  NOT NULL,
    NNombre nvarchar(20)  NOT NULL,
    NApellido nvarchar(20)  NOT NULL,
    Ntipo int  NOT NULL,
    CONSTRAINT Usuario_pk PRIMARY KEY  (idDNI)
);

-- Table: carro
CREATE TABLE carro (
    idCarro int identity NOT NULL,
    NCarro varchar(20)  NOT NULL,
    idMarca int  NOT NULL,
    Precio money  NOT NULL,
    CONSTRAINT carro_pk PRIMARY KEY  (idCarro)
);

-- Table: leasing
CREATE TABLE leasing (
    idLeasing int identity NOT NULL,
    idCarro int  NOT NULL,
    idDNI int  NOT NULL,
    idBanco int  NOT NULL,
    NprevioVenta float(2)  NOT NULL,
    NcuotaInical float(2)  NOT NULL,
    NAnios int  NOT NULL,
    fechaInicio date  NOT NULL,
    idFrecuencia int  NOT NULL,
    CONSTRAINT leasing_pk PRIMARY KEY  (idLeasing)
);

-- foreign keys
-- Reference: Administrador_Usuario (table: Administrador)
ALTER TABLE Administrador ADD CONSTRAINT Administrador_Usuario
    FOREIGN KEY (idUsuario)
    REFERENCES Usuario (idDNI);

-- Reference: Banco_Administrador (table: Banco)
ALTER TABLE Banco ADD CONSTRAINT Banco_Administrador
    FOREIGN KEY (idUsuario)
    REFERENCES Administrador (idUsuario);

-- Reference: Banco_Promocion_Banco (table: Banco_Promocion)
ALTER TABLE Banco_Promocion ADD CONSTRAINT Banco_Promocion_Banco
    FOREIGN KEY (Banco_idBanco)
    REFERENCES Banco (idBanco);

-- Reference: Banco_Promocion_Promocion (table: Banco_Promocion)
ALTER TABLE Banco_Promocion ADD CONSTRAINT Banco_Promocion_Promocion
    FOREIGN KEY (Promocion_idPromocion)
    REFERENCES Promocion (idPromocion);

-- Reference: Banco_Promocion_carro (table: Banco_Promocion)
ALTER TABLE Banco_Promocion ADD CONSTRAINT Banco_Promocion_carro
    FOREIGN KEY (carro_idCarro)
    REFERENCES carro (idCarro);

-- Reference: Cliente_Usuario (table: Cliente)
ALTER TABLE Cliente ADD CONSTRAINT Cliente_Usuario
    FOREIGN KEY (idUsuario)
    REFERENCES Usuario (idDNI);

-- Reference: carro_Marca (table: carro)
ALTER TABLE carro ADD CONSTRAINT carro_Marca
    FOREIGN KEY (idMarca)
    REFERENCES Marca (idMarca);

-- Reference: leasing_Banco (table: leasing)
ALTER TABLE leasing ADD CONSTRAINT leasing_Banco
    FOREIGN KEY (idBanco)
    REFERENCES Banco (idBanco);

-- Reference: leasing_Frecuencia (table: leasing)
ALTER TABLE leasing ADD CONSTRAINT leasing_Frecuencia
    FOREIGN KEY (idFrecuencia)
    REFERENCES Frecuencia (idFrecuencia);

-- Reference: leasing_Usuario (table: leasing)
ALTER TABLE leasing ADD CONSTRAINT leasing_Usuario
    FOREIGN KEY (idDNI)
    REFERENCES Usuario (idDNI);

-- Reference: leasing_carro (table: leasing)
ALTER TABLE leasing ADD CONSTRAINT leasing_carro
    FOREIGN KEY (idCarro)
    REFERENCES carro (idCarro);

-- End of file.


CREATE TRIGGER tr_RegistroRolUsuario
ON Usuario
FOR INSERT
AS
BEGIN
	if (select i.idTipo from inserted i) = 1
	insert into Cliente(idUsuario) select i.idDNI from inserted i 
	else if (select i.idTipo from inserted i) = 2
	insert into Administrador(idUsuario) select i.idDNI from inserted i 
END	

insert into Usuario values('Adrianvc','72941202','Adrian','Vela Cruz',1)
insert into Usuario values('pe@a.com','72941202','Adrian','Vela Cruz',1)
insert into Usuario values('us@a.com','72941202','Manuel','Semanche',2)

select * from Administrador

insert into Frecuencia values('Quincenal',15)
insert into Frecuencia values('Mensual',30)
insert into Frecuencia values('Bimestral',60)
insert into Frecuencia values('Trimestral',90)
insert into Frecuencia values('Cuatrimestral',120)
insert into Frecuencia values('Semestral',180)
insert into Frecuencia values('Anual',360)


insert into Banco values(1,'Interbank',12,0.30,1,350,180,100,1000,null,20,0.30,17.5,10)
insert into Banco values(1,'BCP',9,0.30,1,350,180,100,1000,null,20,0.30,17.5,10)

select * from Banco

insert into Marca values('Nissan')
insert into Marca values('Mitsubishi')
insert into Marca values('Ford')
insert into Marca values('Mazda')

insert into carro values('March',1,12000)
insert into carro values('Tiida',1,13000)
insert into carro values('Fiesta',3,12000)
insert into carro values('Ranger',3,20000)
insert into carro values('Mustang',3,50000)
insert into carro values('Mazda 3',4,18000)
insert into carro values('Mazda 51',4,40000)

insert into PlazoGracia values('Total')
insert into PlazoGracia values('Parcial')
insert into PlazoGracia values('Sin Plazo')

create view nameBanco as select * from Banco
create view vwCarro as select * from carro
