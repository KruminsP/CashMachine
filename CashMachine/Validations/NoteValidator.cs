using System.Linq;

namespace CashMachineCore.Validations
{
    public class NoteValidator
    {
        public static bool IsValid(int amount)
        {
            int[] validNotes = { 5, 10, 20, 50, 100 };
            
            return amount % 5 ==0 && validNotes.Contains(amount);
        }
    }
}