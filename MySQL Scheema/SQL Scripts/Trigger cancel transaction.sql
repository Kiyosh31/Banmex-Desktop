delimiter //
CREATE TRIGGER tr_cancel_transaction AFTER update ON transaction
FOR EACH ROW
IF NEW.CancelTransaction=true
THEN
 UPDATE account SET balance = account.Balance-new.Quantity WHERE account.idAccount = new.DestinyAccount;
 UPDATE account SET balance = account.Balance+new.Quantity WHERE account.idAccount = new.OrigenAccount;
END IF
//