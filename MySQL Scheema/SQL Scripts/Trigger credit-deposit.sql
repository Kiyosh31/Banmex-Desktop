delimiter //
CREATE TRIGGER tr_credito_deposito AFTER Insert ON transaction
FOR EACH ROW
IF new.AccountType = 1 
 THEN
 UPDATE account SET balance = account.Balance-new.Quantity WHERE account.idAccount = new.OrigenAccount AND account.AccountType = 0;
 END IF
//