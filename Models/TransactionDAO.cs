using GoblinPF.Entities;

namespace GoblinPF.Models
{
    public class TransactionDAO
    {
        private GoblinPFDBContext _context;

        public TransactionDAO(GoblinPFDBContext context)
        {
            _context = context;
        }

        public Transaction Add(Transaction trans) 
        {
            _context.Add(trans);
            _context.SaveChanges();
            return trans;
        }
    }
}