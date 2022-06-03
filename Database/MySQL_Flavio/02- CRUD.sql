DROP DATABASE aula2;
CREATE DATABASE aula02;
USE aula02;

CREATE TABLE usuario(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(45),
    ano_nasc DATE,
    sexo ENUM('M', 'F'),
    pais VARCHAR(15)
);

SELECT * FROM usuario;

#Inserindo registros na tabela ----------------------------------------------------------------
INSERT INTO usuario(nome, ano_nasc, sexo, pais) VALUES ('Fulano', '1999-12-27', 'M', 'Brasil');

INSERT INTO usuario(nome, ano_nasc, sexo, pais) VALUES ('Fulano', '1999-12-27', 'M', 'Brasil'),
('Fulano', '1999-12-27', 'M', 'Brasil');

INSERT INTO usuario() VALUES(default, 'Rafael', '1998-06-30', 'M', 'Brasil');

INSERT INTO usuario(nome, sexo, pais)VALUES('Leticia', 'F', 'Italia');

#Atualizando registros-------------------------------------------------------
UPDATE usuario SET nome = 'Jimi' WHERE id = 3;
UPDATE usuario SET ano_nasc = '1942-11-27', pais = 'Inglaterra' WHERE id = 3;

# Deletando registros--------------------------------------------------------
DELETE FROM usuario WHERE id = 2;
