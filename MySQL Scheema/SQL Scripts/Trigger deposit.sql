delimiter //
CREATE TRIGGER tr_deposit AFTER Insert ON depositwithoutaccount
FOR EACH ROW
BEGIN
 UPDATE account SET balance = account.Balance+new.Quantity WHERE account.idAccount = new.DestinyAccount;
END