using CashMachineCore.Models;

namespace CashMachineCore.Validations
{
    public class BalanceValidator
    {
        public static bool IsValid(int amount, Client client)
        {
            return client.Balance >= amount;
        }
    }
}