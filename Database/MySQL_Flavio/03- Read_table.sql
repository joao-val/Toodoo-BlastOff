USE aula02;

CREATE TABLE cliente(
	cpf DECIMAL(11) NOT NULL PRIMARY KEY,
    nome VARCHAR(45),
    idade INT,
    telefone VARCHAR(14),
    cidade VARCHAR(40),
    totalCompra FLOAT
);

INSERT INTO cliente() VALUES
(12379843256, 'João Lucas', 24, '(35)99845-6952', 'Pouso Alegre', 145),
(95487361584, 'Joana', 45, '(35)99972-3348', 'Itajubá', 130.25),
(65482751499, 'Pedro', 33, '(35)99822-5316', 'Itajubá', 78.9),
(57778462358, 'Beatriz', 17, '(35)99735-4442', 'Extrema', 113),
(26326578459, 'Mariana', 28, '(35)98437-6659', 'Barbacena', 42.5),
(76125894362, 'Jonathan', 38, '(35)99233-7453', 'Pouso Alegre', 84.5),
(46582739321, 'Ana Maria', 57, '(35)99118-4742', 'Varginha', 92);

SELECT nome, idade, cidade FROM cliente WHERE cidade = 'Itajubá';

#Busca condicional
SELECT nome, cidade, totalCompra FROM cliente WHERE totalCompra >= 100 AND NOT cidade = 'Itajubá';

SELECT min(totalCompra), max(totalCompra), sum(totalCompra), avg(totalCompra) FROM cliente;

SELECT nome, idade FROM cliente WHERE idade in (SELECT min(idade) FROM cliente);

SELECT nome, max(idade) FROM cliente;

#Filtro para compos de texto 'Jo___%
SELECT * FROM cliente WHERE nome LIKE '%_a';

#Busca com limite de linhas
SELECT nome, telefone FROM cliente LIMIT 3;

#Busca sem repetições
SELECT DISTINCT cidade FROM cliente;