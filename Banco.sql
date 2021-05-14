CREATE DATABASE Condominio;

USE [Condominio];
CREATE TABLE Pessoas (
	IdPessoa int identity(1,1),
	Nome varchar(63) not null, 
	Cpf char(11) unique not null,
	PRIMARY KEY (IdPessoa)
);

CREATE TABLE Moradores(
	IdMorador int FOREIGN KEY REFERENCES Pessoas(IdPessoa),
	Senha char(6),
	IsAtivo bit not null default 1,
	PRIMARY KEY (IdMorador)
);

CREATE TABLE Visitante_Anfitriao(
	IdVisitante_Anfitriao int identity(1,1),
	IdPessoa int not null FOREIGN KEY REFERENCES Pessoas(IdPessoa),
	IdMorador int not null FOREIGN KEY REFERENCES Moradores(IdMorador),
	PRIMARY KEY (IdVisitante_Anfitriao)
);

CREATE TABLE Acessos(
	IdAcesso int identity(1,1),
	IdPessoa int not null FOREIGN KEY REFERENCES Pessoas(IdPessoa),
	TipoAcesso char(1) not null,
	Data_Hora DateTime,
	PRIMARY KEY (IdAcesso)
);

SELECT * FROM Pessoas;
SELECT * FROM Moradores;

INSERT INTO Pessoas (Nome, Cpf) output INSERTED.IdPessoa VALUES ('nome','123123');

SELECT Pessoas.Nome, Pessoas.Cpf, Moradores.IsAtivo
FROM Pessoas
INNER JOIN Moradores ON Pessoas.IdPessoa = Moradores.IdMorador
AND Pessoas.Nome LIKE '%g%'; 

SELECT IdPessoa FROM Pessoas WHERE Cpf = '12312312312';

SELECT Pessoas.IdPessoa, Pessoas.Nome, Pessoas.Cpf,
Moradores.Senha, Moradores.IsAtivo 
FROM Pessoas
INNER JOIN Moradores ON Pessoas.IdPessoa = Moradores.IdMorador;

UPDATE Moradores
SET Senha = '222222' 
WHERE IdMorador = (SELECT IdPessoa FROM Pessoas WHERE Cpf = '12312312312');