namespace Konstruktori_Lesson2
{
    public class BankAccount
    {
        private string id;
        private int amount;
        private string country;

        public  string Id
        {
            get { return id; }
            set {id = value; }
        }

        

        public int Amount
        {
            get { return amount; }
            set {
                
                    amount = value;
                
                }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }





    }
}