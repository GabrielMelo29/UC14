CREATE DATABASE Chapter;

USE Chapter;

CREATE TABLE Livros (
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
);

INSERT INTO Livros VALUES ('Titulo A', 120, 1);
INSERT INTO Livros VALUES ('Titulo B', 220, 0);

SELECT * FROM Livros;

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL,
	Tipo CHAR(1) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@sp.br', '1234', 1)
GO

SELECT * FROM Usuarios WHERE email = 'email@sp.br' AND senha = '1234'
GO
