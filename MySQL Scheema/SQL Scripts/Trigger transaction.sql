delimiter //
CREATE TRIGGER tr_transaction AFTER Insert ON transaction
FOR EACH ROW
BEGIN
 UPDATE account SET balance = account.Balance-new.Quantity WHERE account.idAccount = new.OrigenAccount;
 UPDATE account SET balance = account.Balance+new.Quantity WHERE account.idAccount = new.DestinyAccount;
END
//