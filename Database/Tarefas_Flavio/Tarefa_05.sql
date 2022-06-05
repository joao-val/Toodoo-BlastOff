DROP DATABASE IF EXISTS Tarefa_5;

CREATE DATABASE Tarefa_5;
USE Tarefa_5;

CREATE TABLE tb_client(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    CPF VARCHAR(15) NOT NULL,
    Address VARCHAR(40) NOT NULL
) ENGINE = INNODB;
SHOW TABLE STATUS;

INSERT INTO tb_client(CPF, Address) VALUES
("222.333.444-99", 'Rua 1'),("444.333.222-88", 'Rua 3');

ALTER TABLE tb_client ADD Year_of_birth YEAR NOT NULL;

UPDATE tb_client SET Year_of_birth = '1998' WHERE id = '1'; 
UPDATE tb_client SET Year_of_birth = '1999' WHERE id = '2'; 

DELETE FROM tb_client WHERE id = '1';

DROP TABLE tb_client;

SELECT * FROM tb_client;