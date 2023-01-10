namespace FacadePattern
{
    public class BackAccountFacade
    {
        private int _accountNumber;
        private int _securityCode;

        AccountNumberCheck acctChecker;
        SecurityCodeCheck codeChecker;
        FundsCheck fundChecker;

        WelcomeToBank bankWelcome;
        public BackAccountFacade(int accountNumber, int securityCode)
        {
            _accountNumber = accountNumber;
            _securityCode = securityCode;

            bankWelcome = new WelcomeToBank();
            acctChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
        }

        public int GetAccountNumber() { return _accountNumber; }
        public int GetSecurityCode() { return _securityCode; }
        public void WithdrawCash(double cashToGet)
        {
            if(acctChecker.AccountActive(GetAccountNumber()) && 
                codeChecker.IsCodeCorrect(GetSecurityCode()) && 
                fundChecker.HaveEnoughMoney(cashToGet))
            {
                Console.WriteLine("Transaction Complete");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }

        public void DepositCash(double cashToDepsoit)
        {
            if (acctChecker.AccountActive(GetAccountNumber()) &&
                codeChecker.IsCodeCorrect(GetSecurityCode()))
            {
                fundChecker.MakeDeposit(cashToDepsoit);
                Console.WriteLine("Transaction Complete");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }
    }
}