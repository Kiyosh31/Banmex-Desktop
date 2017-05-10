delimiter //
CREATE TRIGGER tr_transaccion_cancelada_destino AFTER UPDATE ON transaction
FOR EACH ROW
UPDATE account SET balance = account.Balance-new.Quantity WHERE account.idAccount = new.DestinyAccount;
//