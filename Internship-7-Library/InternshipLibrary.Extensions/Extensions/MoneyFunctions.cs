using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Extensions.Extensions
{
    public static class MoneyFunctions
    {
        public static double CountLoan(DateTime ShouldHaveBeenReturned)
        {
            var HowMuchIsADayWorth = 0.5;
            if (ShouldHaveBeenReturned.Month < DateTime.Now.Month)
                return (DateTime.Now.Subtract(ShouldHaveBeenReturned).Days * HowMuchIsADayWorth);
            else
                return 0;
        }
    }
}
