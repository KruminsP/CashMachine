namespace CashMachineCore.Models
{
    public class Client
    {
        public string Name { get; set; }
        public int Balance { get; set; }

        public Client(string name)
        {
            Balance = 0;
            Name = name;
        }
    }
}