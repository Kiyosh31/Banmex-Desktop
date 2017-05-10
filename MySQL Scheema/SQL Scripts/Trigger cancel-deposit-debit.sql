delimiter //
CREATE TRIGGER tr_cancel_deposit_debit AFTER UPDATE ON depositwithoutaccount
FOR EACH ROW
UPDATE account SET Balance=Balance-NEW.Quantity WHERE account.AccountType = 1 AND NEW.DestinyAccount = account.idAccount
//