DROP DATABASE IF EXISTS stock;
CREATE DATABASE stock;

USE stock;

CREATE TABLE Products(
    id INT PRIMARY KEY,
    descricao VARCHAR(50) UNIQUE,
    stock INT NOT NULL
);

INSERT INTO Products VALUES 
('1', 'Lasanha', '10'), ('2', 'Morango', '5'), ('3', 'Farinha', '15');

CREATE TABLE Sale_items (
    sale_id INT PRIMARY KEY,
    product_id INT,
    quantity INT
);

DROP TRIGGER restore_stock;

INSERT INTO Sale_items VALUES
(2, 1, 2);

DELETE FROM Sale_items WHERE Sale_id = 5;

SELECT * FROM Products;