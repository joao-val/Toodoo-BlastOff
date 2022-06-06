USE aula;

DELIMITER $$
CREATE FUNCTION buy_change(cost FLOAT, payment FLOAT) RETURNS VARCHAR(20)
BEGIN
	DECLARE result VARCHAR(20);
	IF((payment - cost) < 0.05) THEN
		SET result = "No change";
	ELSEIF((payment - cost) <= 1) THEN
		SET result = "Coffee candies";
	ELSE 
		SET result = "Change";
    end if;       
	return CONCAT(result);	
END $$
DELIMITER ;