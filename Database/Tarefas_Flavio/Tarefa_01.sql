
USE c207;
DROP TABLE tb_client;
CREATE TABLE tb_client(
	cpf VARCHAR(15) NOT NULL PRIMARY KEY,
    nome VARCHAR(45),
    address VARCHAR(40),
    year_of_birth DATE
);

SELECT * FROM tb_client;
INSERT INTO tb_client(cpf, nome, address, year_of_birth) VALUES
('12345678910', 'Flavio', 'Rua 1', '1998-09-04'), ('123.555.888-98', 'João','Rua 2', '1998-03-14'),
('222.444.666-99', 'Maria', 'Rua 3', '2000-10-15');

UPDATE tb_client SET address = 'Avenida 3' WHERE cpf = '222.444.666-99';

SELECT nome, cpf FROM tb_client;

DELETE FROM tb_client WHERE cpf = '123.555.888-98';