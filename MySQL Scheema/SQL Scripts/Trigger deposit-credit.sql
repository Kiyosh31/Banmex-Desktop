delimiter //
CREATE TRIGGER tr_deposit_credit AFTER Insert ON depositwithoutaccount
FOR EACH ROW
UPDATE account SET Balance=Balance-NEW.Quantity WHERE account.AccountType = 0 AND New.DestinyAccount = account.idAccount
//