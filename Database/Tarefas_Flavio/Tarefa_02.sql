USE c207;

DROP TABLE tb_empresa;

CREATE TABLE tb_empresa(
	Registration INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(45) NOT NULL,
    CPF VARCHAR(15) NOT NULL,
    Position VARCHAR(40) NOT NULL,
    Project_quantity INT NOT NULL
);

SELECT * FROM tb_empresa;

# A)
INSERT INTO tb_empresa( Nome, CPF, Position, Project_quantity) VALUES
('Alexandre', '000.000.000-00', 'GP', '2'), 
('Natanael', '111.111.111-11', 'Developer','4'),
('Rochelle', '222.222.222-22', 'Tester', '3'),
('Jane', '333.333.333-33', 'Developer', 5);

# B)
SELECT Nome, CPF, Position, min(Project_quantity) FROM tb_empresa;
SELECT Nome, CPF, Position, max(Project_quantity) FROM tb_empresa;

# C)
SELECT avg(Project_quantity) AS Project_Average FROM tb_empresa WHERE Position <> 'GP';

# D)
SELECT * FROM tb_empresa WHERE Project_quantity >= 4;

# E)
SELECT DISTINCT Position FROM tb_empresa;

# F)
SELECT Nome, CPF, Project_quantity FROM tb_empresa WHERE Position = 'Developer';