using System.ComponentModel.DataAnnotations;
namespace CH02FutureValueChristensen.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please Enter a Monthly Investment.")]
        [Range(1,500, ErrorMessage = "Investment must be between 1 and 500.")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Please enter a Yearly InterestRate.")]
        [Range(0.1, 10.0, ErrorMessage ="Interesst Rate must be between 0.1 and 10.0.")]
        public decimal? YearlyInterestRate { get; set; }
        [Required(ErrorMessage = " Please enter the number of years you would like to have the invesstment.")]
        [Range(1, 50, ErrorMessage = "Investment can only be in for 1 to 50 years.")]
        public int Years  { get; set; }

        public decimal CalculateFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInterestRate = YearlyInterestRate.Value / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment.Value) *
                    (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
