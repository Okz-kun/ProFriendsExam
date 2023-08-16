using System;

namespace LoanScheduler.Models
{
    public class InputModel
    {
        public double SellingPrice { get; set; }

        public DateTime ReservationDate { get; set; }

        public int EquityTerm { get; set; }
    }
}