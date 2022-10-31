namespace CashMachineCore.Validations
{
    public class AmountValidator
    {
        public static bool IsValid(int amount)
        {
            return amount > 0;
        }
    }
}
