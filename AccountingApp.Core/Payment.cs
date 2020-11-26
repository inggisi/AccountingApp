using System;

namespace AccountingApp.Core
{
    public class Payment
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public PostingType PostingType { get; set; }
        public Account Account { get; set; }
        public DateTime PostingDate { get; set; }
        public PostingFrequency PostingFrequency { get; set; }
        public DateTime FinishingDate { get; set; }
        public User User { get; set; }
        public string Comment { get; set; }
    }
}