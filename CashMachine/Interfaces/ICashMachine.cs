namespace CashMachineCore.Interfaces
{
    // Please implement interface ICashMachine. Cash machine accepts/withdraws only 5, 10, 20, 50, 100 banknotes.
    // Please write some unit tests if possible.
    public interface ICashMachine
    {
        int Withdraw(int amount);
        void Insert(int[] cash);
    }

}