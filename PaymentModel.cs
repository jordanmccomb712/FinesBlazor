using System.ComponentModel.DataAnnotations;

public class FromNowAttribute : ValidationAttribute
    {
        public FromNowAttribute() {}

        public string GetErrorMessage() => "Date must be in future";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;

            if (DateTime.Compare(date, DateTime.Now) < 0) return new ValidationResult(GetErrorMessage());
            else return ValidationResult.Success;
        }
    }
public class PaymentModel

{
    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    [FromNow]
    public DateTime? ExpDate { get; set; }

    [Required]
    // [CreditCard]
    public string? CardNum { get; set; }

    [Required]
    public string? CVC { get; set; }
    public string? FineID { get; set; }
}