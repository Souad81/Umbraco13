using System.ComponentModel.DataAnnotations;

namespace UmbracoCMS.ViewModels;

public class CallbackFormViewModel
{
    [Required(ErrorMessage = "Name is required")]
    [Display(Name = "Name")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Email is required")]
    [Display(Name = "Email address")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Phone is required")]
    [Display(Name = "Phone")]
    public string Phone { get; set; } = null!;

    [Required(ErrorMessage = "Please select an option")]

    public string SelectedOption { get; set; } = null!;
}
