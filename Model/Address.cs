
using System.ComponentModel.DataAnnotations;
namespace BlazingPizza
{
    public class Address
{
    public int Id { get; set; }

    [Required, MinLength(3, ErrorMessage = "Please use a Name bigger than 3 letters."), MaxLength(100, ErrorMessage = "Please use a Name less than 100 letters.")]
    public string Name { get; set; }

    [Required, MinLength(5, ErrorMessage = "Please use an Address bigger than 5 letters."), MaxLength(100, ErrorMessage = "Please use an Address less than 100 letters.")]
    public string Line1 { get; set; }

    [MaxLength(100)]
    public string Line2 { get; set; }

    [Required, MinLength(3, ErrorMessage = "Please use a City bigger than 3 letters."), MaxLength(50, ErrorMessage = "Please use a City less than 50 letters.")]
    public string City { get; set; }

    [Required, MinLength(3, ErrorMessage = "Please use a Region bigger than 3 letters."), MaxLength(20, ErrorMessage = "Please use a Region less than 20 letters.")]
    public string Region { get; set; }

    [Required, RegularExpression(@"^([A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]? {1,2}[0-9][ABD-HJLN-UW-Z]{2}|GIR 0AA)$", ErrorMessage = "Please enter a valid postcode")]
    public string PostalCode { get; set; }
}
}
