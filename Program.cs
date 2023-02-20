using ByteBank;

CheckingAccount firstPersonAccount = new CheckingAccount();
firstPersonAccount.owner = "André Silva";
firstPersonAccount.number_branch = 3306;
firstPersonAccount.account = "1010-X";
firstPersonAccount.account_balance = 1050.40;

Console.WriteLine("Balance: " + firstPersonAccount.account_balance);

firstPersonAccount.Deposit(250.87);

Console.WriteLine("Balance: " + firstPersonAccount.account_balance);

firstPersonAccount.Withdrawal(289.90);

Console.WriteLine("Balance: " + firstPersonAccount.account_balance);