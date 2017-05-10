delimiter //
CREATE TRIGGER tr_deposit_debit AFTER Insert ON depositwithoutaccount
FOR EACH ROW
UPDATE account SET Balance=Balance+NEW.Quantity WHERE account.AccountType = 1 AND NEW.DestinyAccount = account.idAccount
//