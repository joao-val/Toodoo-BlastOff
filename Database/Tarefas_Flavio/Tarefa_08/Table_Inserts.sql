DROP DATABASE IF EXISTS aula;

CREATE DATABASE aula;
USE aula;

#SET SQL_SAFE_UPDATES=0;

CREATE TABLE Student (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome varchar(50),
    age int,
    email varchar(100)
);

CREATE TABLE Buy (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome varchar(50),
    cost FLOAT,
    payment FLOAT
);

CALL insert_student('Dragonborn', 1000, 'dovahkiin@gmail.com');

#SET GLOBAL log_bin_trust_function_creators =1;

#Select * FROM Buy;
SELECT *, buy_change(cost, payment) FROM Buy;

INSERT INTO buy (nome, cost, payment) VALUES
("Goku", 15, 72), ("Freeza", 13.20, 13.23), ("Vegeta", 114, 115), ("Luffy", 12, 21);

SELECT *, buy_change(cost, payment) FROM Buy;