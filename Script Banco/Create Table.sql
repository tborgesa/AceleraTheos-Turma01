create database PETSHOP

use PETSHOP

CREATE TABLE Cliente(
	IdCliente uniqueidentifier NOT NULL CONSTRAINT [PK_IdCliente] PRIMARY KEY,
	DataInsercao smalldatetime NOT NULL,
	Nome varchar(100) NOT NULL,
	Telefone varchar(11) NOT NULL,
	Endereco varchar(500) NULL,
	DataAlteracao smalldatetime NULL,
 )

 ALTER TABLE Cliente ADD CONSTRAINT [DF_DataInsercao]  DEFAULT (getdate()) FOR [DataInsercao]

 create table Especies
 (
 IdEpecie numeric not null CONSTRAINT [PK_Especie] PRIMARY KEY,
 Descricao varchar(10) not null,
 )

 insert into Especies(idEpecie, Descricao) values (1, 'CACHORRO'), (2, 'GATO'), (3, 'PEIXE')

 create table Cachorro
(
	IdCachorro uniqueidentifier not null CONSTRAINT [PK_IdCachorro] PRIMARY KEY,
	DataInsercao smalldatetime not null, 
	NomeCachorro varchar(100) not null,
	IdCliente uniqueidentifier not null,
	IdEspecie numeric not null,
	Raca varchar(50),
	Peso numeric not null,
	ValorLimpeza numeric,
	DataAlteracao smalldatetime,
	CONSTRAINT [FK_IdCliente] FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente),
	CONSTRAINT [FK_Especie] FOREIGN KEY (IdEspecie) REFERENCES Especies (IdEpecie)
);

ALTER TABLE Cachorro ADD  CONSTRAINT [DF_DataInsercaoCachorro]  DEFAULT (getdate()) FOR [DataInsercao]

create table Gato
(
	IdGato uniqueidentifier not null CONSTRAINT [PK_IdGato] PRIMARY KEY,
	DataInsercao smalldatetime not null, 
	NomeCachorro varchar(100) not null,
	IdCliente uniqueidentifier not null,
	IdEspecie numeric not null,
	Raca varchar(50),
	Peso numeric not null,
	ValorLimpeza numeric,
	DataAlteracao smalldatetime,
	CONSTRAINT [FK_IdClienteG] FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente),
	CONSTRAINT [FK_EspecieG] FOREIGN KEY (IdEspecie) REFERENCES Especies (IdEpecie)
);

ALTER TABLE Gato ADD  CONSTRAINT [DF_DataInsercaoGato]  DEFAULT (getdate()) FOR [DataInsercao]