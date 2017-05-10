delimiter //
CREATE TRIGGER Before_Insert_User
BEFORE INSERT ON Client
FOR EACH ROW
BEGIN
  IF (EXISTS(SELECT FirstName FROM Client WHERE FirstName = NEW.FirstName)) THEN
    SIGNAL SQLSTATE VALUE '45000' SET MESSAGE_TEXT = 'Insercion fallida este cliente ya existe';
  END IF//