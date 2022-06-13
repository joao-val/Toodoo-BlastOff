DROP DATABASE IF EXISTS store;
CREATE DATABASE store;

USE store;

CREATE TABLE Buy(
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    price FLOAT,
    payment FLOAT
);

INSERT INTO Buy (price, payment) VALUES 
(9.5, 10.25), (18.99, 25), (3.99, 5), (8.85, 8.89), (19.49, 20);

CREATE VIEW buy_view AS (
	SELECT COUNT(id) AS 'Products with price greater than 10' FROM Buy WHERE price > 10
); 

SELECT * FROM buy_view;
