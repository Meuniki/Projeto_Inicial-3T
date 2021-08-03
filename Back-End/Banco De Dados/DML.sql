USE Projeto_Inicial;
GO

INSERT INTO Usuarios(email, senha, nome)
VALUES		('adm@adm.com','adm123', 'Administrador')
		   ,('user@user.com', 'user1123', 'Usuário');
GO

INSERT INTO Equipamentos(marca, tipoEquipamento, numSerie, descricao, numPatrimonio, ativo)
VALUES		('Acer','Computador', '91847297510', 'Computador Gamer', '1', '1')
		   ,('Dell','Computador', '83201853868', 'Computador Rápido', '2', '1')
		   ,('Lenovo','Computador', '10482953217', 'Computador Potente', '3', '1')
		   ,('Toshiba','Computador', '73027513846', 'Computador Custo-Benefício', '4', '0');
GO

INSERT INTO Salas(andar, nome, metragemSala)
VALUES			 ('1', 'Sala 1', '22.39')
				,('1', 'Sala 2', '10.09')
				,('2', 'Sala 3', '22.39')
				,('2', 'Sala 4', '10.09')
				,('3', 'Sala 5', '22.39')
				,('3', 'Sala 6', '10.09');
GO

INSERT INTO Entradas(idSala, idEquipamento, dataEntrada, dataSaida)
VALUES      ('1', '2', '2021-08-03T08:00:00', '2021-08-03T12:00:00')
		   ,('2', '1', '2021-08-03T08:00:00', '2021-08-03T12:00:00')
		   ,('3', '3', '2021-08-03T08:00:00', '2021-08-03T12:00:00')
		   ,('4', '1', '2021-08-03T14:00:00', '2021-08-03T22:00:00')
		   ,('5', '2', '2021-08-03T14:00:00', '2021-08-03T22:00:00')
		   ,('6', '3', '2021-08-03T14:00:00', '2021-08-03T22:00:00');
GO