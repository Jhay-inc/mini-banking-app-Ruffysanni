namespace BankingApplication
{
    internal class BankCustomer
    {
        private string v1;
        private string v2;

        public BankCustomer(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public object AccountNumber { get; set; }
    }
}