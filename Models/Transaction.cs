namespace GoblinPF.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public bool BuySell { get; set; }
        public string Category { get; set; }
    }
}