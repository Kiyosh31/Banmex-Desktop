delimiter //
CREATE TRIGGER tr_cancel_deposit AFTER update ON depositwithoutaccount
FOR EACH ROW
IF NEW.CancelTransaction=true
THEN
 UPDATE account SET balance = account.Balance-new.Quantity WHERE account.idAccount = new.DestinyAccount;
END IF
//