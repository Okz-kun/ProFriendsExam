using LoanScheduler.Models;
using LoanScheduler.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace LoanScheduler.Services
{
    public class LoanService : ILoanService
    {

        public List<HeaderModel> CalculateLoan(InputModel inputData) { 

            var schedList = new List<HeaderModel>();

            var inputs = inputData;

            var monthlyAmount = CalculateMonthlyAmount(inputs.SellingPrice, inputs.EquityTerm);

            var startDate = CalculateStartDate(inputData.ReservationDate);

           for (int i = 0; i < inputData.EquityTerm; i++)
           {
                var sched = new HeaderModel();

                sched.Balance = inputs.SellingPrice - (monthlyAmount * (i + 1));

                sched.DueDate = startDate.AddMonths(i);

                sched.Term = i + 1;

                sched.Details = new DetailsModel()
                {
                    Amount = monthlyAmount,

                    Intereset = CalculateInterest(sched.Balance),

                    Insurance = CalculateInsurance(monthlyAmount),
                };

                schedList.Add(sched);
           }



            return schedList;
        }

        public double CalculateMonthlyAmount(double sellingPrice, int equityTerm)
        {

            double result = 0;

            result = sellingPrice / equityTerm;

            return result;
        }

        public DateTime CalculateStartDate(DateTime reservationDate)
        {

            DateTime startDate;

            startDate = reservationDate.AddMonths(1);

            return startDate;
        }

        public double CalculateInterest(double balance)
        {
            double interestRate = 0.05;
            double interest = balance * interestRate;

            return interest;

        }

        public double CalculateInsurance(double amount)
        {
            double insuranceRate = 0.01;
            double insurance = amount * insuranceRate;

            return insurance;

        }


    }




}