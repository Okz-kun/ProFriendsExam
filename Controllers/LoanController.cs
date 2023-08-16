using LoanScheduler.Models;
using LoanScheduler.Services;
using LoanScheduler.Services.Interfaces;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;

namespace LoanScheduler.Controllers
{
    [RoutePrefix("api/loan")]
    public class LoanController : ApiController
    {
        private readonly ILoanService loanService;

        public LoanController(LoanService loanService)
        {
            this.loanService = loanService;
        }

        // GET: Loan
        [HttpPost]
        [Route("calculate-loan-schedule")]
        public List<HeaderModel> CalculateLoanSchedule(InputModel inputData)
        {
            return loanService.CalculateLoan(inputData);
        }
    }
}