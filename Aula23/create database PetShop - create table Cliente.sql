/*
Nome = nome;
Telefone = telefone;
Endereco = endereco;
public Guid Id { get; private set; }
public DateTime DataInsercao { get; }
public DateTime DataAlteracao { get; private set; }
private List<string> _erros = new List<string>();
*/

use PETSHOP

create table Cliente
(
	IdCliente uniqueidentifier not null,
	DataInsercao smalldatetime not null Constraint DF_DataInsercao default (getdate()),
	Nome varchar(100) not null,
	Telefone varchar(11) not null,
	Endereco varchar(500),
	DataAlteracao smalldatetime,
	CONSTRAINT PK_IdCliente PRIMARY KEY (IdCliente)
)

insert into dbo.Cliente values (NEWID(), GETDATE(), 'Talita Monteiro', '4499817196', 'Rua Adão Eloi Trojan', null)


drop table Cliente


