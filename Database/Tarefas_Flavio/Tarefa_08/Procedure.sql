USE aula;

DELIMITER //
CREATE PROCEDURE insert_student(Nome VARCHAR(50), age INT, email VARCHAR(100))
BEGIN
	INSERT INTO Student(nome, age, email) VALUES (nome, age, email);
    UPDATE Student SET age = 20 WHERE id = LAST_INSERT_ID();
    DELETE FROM Student WHERE id % 2 = 0;
END //
DELIMITER ;