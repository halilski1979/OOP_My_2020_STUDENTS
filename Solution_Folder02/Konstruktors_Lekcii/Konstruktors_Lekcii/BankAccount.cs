namespace Konstruktors_Lekcii
{
    public class BankAccount
    {
        private string id;
        private double amount;

        public BankAccount()
        {
        }

        public BankAccount(string id, double amount)
        {
            this.id = id;
            this.amount = amount;
        }

        public string Id { get => id; set => id = value; }
        public double Amount { get => amount; set => amount = value; }


    }
}