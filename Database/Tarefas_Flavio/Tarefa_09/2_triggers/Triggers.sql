DELIMITER $$
CREATE TRIGGER decrease_stock AFTER INSERT ON Sale_items
FOR EACH ROW
BEGIN
	UPDATE Products 
    SET stock = stock - NEW.quantity 
    WHERE id = NEW.product_id;
END$$
DELIMITER ;

DELIMITER \\
CREATE TRIGGER restore_stock AFTER DELETE ON Sale_items 
FOR EACH ROW
BEGIN
	UPDATE Products 
    SET stock = stock + OLD.quantity 
    WHERE id = OLD.product_id;
END\\
DELIMITER ;