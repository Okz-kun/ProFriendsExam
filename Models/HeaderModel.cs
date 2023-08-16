using System;

namespace LoanScheduler.Models
{
    public class HeaderModel
    {
        public double Balance { get; set; }

        public DateTime DueDate { get; set; }

        public int Term { get; set; }

        public DetailsModel Details { get; set; }
    }
}