USE Projeto_Inicial;
GO

INSERT INTO Usuarios(email, senha, nome)
VALUES		('adm@adm.com','adm123', 'Administrador')
		   ,('user@user.com', 'user1123', 'Usu�rio');
GO

INSERT INTO Equipamentos(marca, tipoEquipamento, numSerie, descricao, numPatrimonio, ativo)
VALUES		('Acer','Computador', '9184729751', 'Computador Gamer', '1', '1')
		   ,('Dell','Computador', '8320185386', 'Computador R�pido', '2', '1')
		   ,('Lenovo','Computador', '1048295321', 'Computador Potente', '3', '1')
		   ,('Toshiba','Computador', '7302751384', 'Computador Custo-Benef�cio', '4', '0');
GO

INSERT INTO Salas(instituicao, andar, nome, metragemSala, cep, telefone)
VALUES			 ('J�ssica e Antonio Entregas Expressas ME', '1', 'Sala 1', '22.39', '05790440', '1125783163')
				,('J�ssica e Antonio Entregas Expressas ME', '1', 'Sala 2', '10.09', '05790440', '1125783163')
				,('J�ssica e Antonio Entregas Expressas ME', '2', 'Sala 3', '22.39', '05790440', '1125783163')
				,('J�ssica e Antonio Entregas Expressas ME', '2', 'Sala 4', '10.09', '05790440', '1125783163')
				,('J�ssica e Antonio Entregas Expressas ME', '3', 'Sala 5', '22.39', '05790440', '1125783163')
				,('J�ssica e Antonio Entregas Expressas ME', '3', 'Sala 6', '10.09', '05790440', '1125783163');
GO

INSERT INTO Entradas(idSala, idEquipamento, dataEntrada, dataSaida)
VALUES      ('1', '2', '2021-08-03T08:00:00', '2021-08-03T12:00:00')
		   ,('2', '1', '2021-08-03T08:00:00', '2021-08-03T12:00:00')
		   ,('3', '3', '2021-08-03T08:00:00', '2021-08-03T12:00:00')
		   ,('4', '1', '2021-08-03T14:00:00', '2021-08-03T22:00:00')
		   ,('5', '2', '2021-08-03T14:00:00', '2021-08-03T22:00:00')
		   ,('6', '3', '2021-08-03T14:00:00', '2021-08-03T22:00:00');
GO