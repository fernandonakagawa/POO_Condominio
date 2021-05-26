INSERT INTO Pessoas (Nome, Cpf) VALUES ('Visitante 1', '55555555');
INSERT INTO Pessoas (Nome, Cpf) VALUES ('Visitante 2', '33333333');

INSERT INTO Visitante_Anfitriao (IdPessoa, IdMorador) VALUES(8,1);
INSERT INTO Visitante_Anfitriao (IdPessoa, IdMorador) VALUES(9,3);

SELECT Pessoas.IdPessoa, Pessoas.Nome, Pessoas.Cpf,
Moradores.Senha, Moradores.IsAtivo 
FROM Pessoas
INNER JOIN Moradores ON Pessoas.IdPessoa = Moradores.IdMorador;

CREATE VIEW Pessoas_Moradores_View AS
SELECT Pessoas.IdPessoa, Pessoas.Nome, Pessoas.Cpf,
Moradores.Senha, Moradores.IsAtivo 
FROM Pessoas
INNER JOIN Moradores ON Pessoas.IdPessoa = Moradores.IdMorador;

CREATE VIEW Pessoas_Visitantes_View AS
SELECT Pessoas.IdPessoa, Pessoas.Nome, Pessoas.Cpf, Visitante_Anfitriao.IdMorador 
FROM Pessoas
INNER JOIN Visitante_Anfitriao ON Pessoas.IdPessoa = Visitante_Anfitriao.IdPessoa;

SELECT Pessoas_Visitantes_View.Nome, Pessoas_Visitantes_View.Cpf FROM Pessoas_Visitantes_View
INNER JOIN Pessoas_Moradores_View ON Pessoas_Visitantes_View.IdMorador = Pessoas_Moradores_View.IdPessoa
WHERE Pessoas_Moradores_View.Cpf = '23456789012';