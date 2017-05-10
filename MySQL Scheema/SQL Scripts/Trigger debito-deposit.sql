delimiter //
CREATE TRIGGER tr_debito_deposito AFTER Insert ON transaction
FOR EACH ROW
IF new.AccountType = 0
 THEN
 UPDATE account SET balance = account.Balance-new.Quantity WHERE account.idAccount = new.OrigenAccount AND account.AccountType = 2;
 UPDATE account SET balance = account.Balance+new.Quantity WHERE account.idAccount = new.DestinyAccount AND account.AccountType = 2;
END IF
//