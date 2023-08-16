using LoanScheduler.Models;
using System;
using System.Collections.Generic;

namespace LoanScheduler.Services.Interfaces
{
    public interface ILoanService
    {
        List<HeaderModel> CalculateLoan(InputModel inputData);

        double CalculateMonthlyAmount(double sellingPrice, int equityTerm);

        DateTime CalculateStartDate(DateTime reservationDate);

        double CalculateInterest(double balance);

        double CalculateInsurance(double amount)
    }
}
