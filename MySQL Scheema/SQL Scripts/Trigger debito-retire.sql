delimiter //
CREATE TRIGGER tr_debito_retiro AFTER Insert ON transaction
FOR EACH ROW
IF new.AccountType = 2 
 THEN
 UPDATE account SET balance = account.Balance-new.Quantity WHERE account.idAccount = new.OrigenAccount AND account.AccountType = 1;
END IF
//