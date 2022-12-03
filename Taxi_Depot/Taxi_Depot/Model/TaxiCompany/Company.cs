namespace Taxi_depot.Model.TaxiCompany
{
    public class Company : Depo
    {
        int balance;
        public static List<Company> CompanyList = new List<Company>();
        public Company(int balance = 0)
        {
            this.balance = balance;
            CompanyList.Add(this);
        }
        public void spendMoney(int amount)
        {
            CompanyList[0].balance -= amount;
        }
        public int GetBalance()
        {
            return CompanyList[0].balance;
        }
        public void AddMoney(int amount)
        {
            CompanyList[0].balance += amount;
        }
    }
}
