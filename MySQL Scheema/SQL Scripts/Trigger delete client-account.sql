delimiter //
CREATE TRIGGER tr_cancelar_cuenta AFTER UPDATE ON client
FOR EACH ROW
IF new.Active=false
THEN 
UPDATE account SET Active=false WHERE new.idClient = account.Client_idClient;
END IF//