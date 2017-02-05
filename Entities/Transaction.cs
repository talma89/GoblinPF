namespace GoblinPF.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public bool BuySell { get; set; }
        public Category Category { get; set; }
    }
}