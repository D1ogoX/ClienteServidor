CREATE TABLE tbUtilizador
(
	idUtilizador int NOT NULL UNIQUE IDENTITY(1,1), --Define que é campo incremental
	email varchar(150) PRIMARY KEY,
	password text NOT NULL,
	nome varchar(255) NOT NULL,
	UUID UNIQUEIDENTIFIER DEFAULT NEWID(), --Define um GUID para fazer a confirmação da conta por email
	dataCriado datetime NOT NULL DEFAULT GETDATE() --Coloca automaticamente a data atual do sistema quando o registo for inserido
);

CREATE TABLE tbAnuncios
(
	idAnuncio int PRIMARY KEY IDENTITY(1,1),
	titulo varchar(100) NOT NULL,
	descricao text NOT NULL,
	dataCriado datetime NOT NULL DEFAULT GETDATE(),
	idUtilizador int NOT NULL FOREIGN KEY REFERENCES tbUtilizador (idUtilizador),
	publicado bit NOT NULL DEFAULT 0
);