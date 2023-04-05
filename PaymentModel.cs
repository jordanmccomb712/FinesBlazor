using System.ComponentModel.DataAnnotations;
public class PaymentModel

{
    public string? Title { get; set; }
    public string? Name { get; set; }
    public DateTime? Date { get; set; }

    [Required]
    // [CreditCardAttribute]
    public int? CardNum { get; set; }

    [Required]
    // [IntLength(3, ErrorMessage = "CVC must be 3 digits long.")]
    public int? CVC { get; set; }
    public string? FineID { get; set; }
}