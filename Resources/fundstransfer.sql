CREATE DEFINER=`root`@`localhost` PROCEDURE `FundsTransfer`(IN amount INT, IN fromacct INT, IN toaccount INT)
BEGIN
START TRANSACTION;
	SET @Amount=amount;
	SET @FromAccount=fromacct;
	SET @ToAccount=toaccount;
	UPDATE accounts SET balance=balance-@Amount WHERE accountid=@FromAccount;
	UPDATE accounts SET balance=balance+@Amount WHERE accountid=@ToAccount;
COMMIT;
END