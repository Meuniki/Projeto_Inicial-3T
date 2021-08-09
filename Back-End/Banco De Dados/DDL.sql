CREATE DATABASE Projeto_Inicial;
GO

USE Projeto_Inicial;
GO

CREATE TABLE Usuarios
(
	idUsuario		INT PRIMARY KEY IDENTITY
	,email			VARCHAR(150) UNIQUE NOT NULL
	,senha			VARCHAR(150) NOT NULL
	,nome			VARCHAR(150) NOT NULL
);
GO

CREATE TABLE Equipamentos
(
	idEquipamento		INT PRIMARY KEY IDENTITY
	,marca				VARCHAR(150) NOT NULL
	,tipoEquipamento	VARCHAR(150) NOT NULL
	,numSerie			CHAR(10) NOT NULL
	,descricao			TEXT NOT NULL
	,numPatrimonio		CHAR(10) UNIQUE NOT NULL
	,ativo				BIT NOT NULL
);
GO

CREATE TABLE Salas
(
	idSala				INT PRIMARY KEY IDENTITY
	,instituicao		VARCHAR(150) NOT NULL
	,andar				CHAR(2) NOT NULL
	,nome				VARCHAR(150) UNIQUE NOT NULL
	,metragemSala		FLOAT NOT NULL
	,cep				CHAR(13) NOT NULL
	,telefone			CHAR(11) NOT NULL
);
GO

CREATE TABLE Entradas
(
	idEntrada			INT PRIMARY KEY IDENTITY
	,idSala				INT FOREIGN KEY REFERENCES Salas(idSala)
	,idEquipamento		INT FOREIGN KEY REFERENCES Equipamentos(idEquipamento)
	,dataEntrada		DATETIME NOT NULL
	,dataSaida			DATETIME
);
GO