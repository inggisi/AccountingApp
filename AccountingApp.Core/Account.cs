namespace AccountingApp.Core
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}