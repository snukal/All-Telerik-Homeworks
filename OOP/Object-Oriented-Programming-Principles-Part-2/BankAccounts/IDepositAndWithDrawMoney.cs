namespace BankAccounts
{
    public interface IDepositAndWithDrawMoney : IDepositMoney
    {
        void WithDraw(decimal amount);
    }
}
