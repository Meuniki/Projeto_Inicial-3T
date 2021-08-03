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
	,numSerie			BIGINT NOT NULL
	,descricao			VARCHAR(150) NOT NULL
	,numPatrimonio		INT UNIQUE NOT NULL
	,ativo				BIT NOT NULL
);
GO

CREATE TABLE Salas
(
	idSala			INT PRIMARY KEY IDENTITY
	,andar			INT NOT NULL
	,nome			VARCHAR(150) UNIQUE NOT NULL
	,metragemSala	FLOAT NOT NULL
);
GO

CREATE TABLE Entradas
(
	idEntrada			INT PRIMARY KEY IDENTITY
	,idSala				INT FOREIGN KEY REFERENCES Salas(idSala)
	,idEquipamento		INT FOREIGN KEY REFERENCES Equipamentos(idEquipamento)
	,dataEntrada		DATETIME NOT NULL
	,dataSaida			DATETIME NOT NULL
);
GO