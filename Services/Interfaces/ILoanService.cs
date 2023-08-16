using LoanScheduler.Models;
using System.Collections.Generic;

namespace LoanScheduler.Services.Interfaces
{
    public interface ILoanService
    {
        List<HeaderModel> CalculateLoan(InputModel inputData);
    }
}
