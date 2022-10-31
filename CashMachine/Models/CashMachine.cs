using CashMachineCore.Exceptions;
using CashMachineCore.Interfaces;
using CashMachineCore.Validations;

namespace CashMachineCore.Models
{
    public class CashMachine : ICashMachine
    {
        private readonly Client _client;

        public CashMachine(Client client)
        {
            _client = client;
        }

        public int Withdraw(int amount)
        {
            if (!AmountValidator.IsValid(amount) || !NoteValidator.IsValid(amount))
            {
                throw new InvalidAmountException();
            }

            if (!BalanceValidator.IsValid(amount, _client))
            {
                throw new InvalidBalanceException();
            }

            _client.Balance -= amount;

            return amount;
        }

        public void Insert(int[] cash)
        {
            foreach (var note in cash)
            {
                if (!NoteValidator.IsValid(note))
                {
                    throw new InvalidAmountException();
                }
            }

            foreach (var note in cash)
            {
                _client.Balance += note;
            }
        }
    }
}
