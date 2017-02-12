using System;
using System.ComponentModel.DataAnnotations;

namespace GoblinPF.Entities
{
    public class Transaction
    {
        public int Id { get; set; }

        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        public bool BuySell { get; set; }
        public Category Category { get; set; }
        public DateTime TimeStamp 
        { 
            get 
            {
                return this.timeStamp.HasValue
                    ? this.timeStamp.Value
                    : DateTime.Now;
            } 
        
            set{ this.timeStamp = value; }
        }
        private DateTime? timeStamp = null;

        public Transaction()
        {
            TimeStamp = DateTime.Now;
        }
    }
}