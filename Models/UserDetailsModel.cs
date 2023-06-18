using System.ComponentModel.DataAnnotations;

namespace uniProject.Models;

public class UserDetailsModel
{
    [Display(Name = "کد ملی")]
    public int NationalSignup { get; set; }
    [Display(Name = "کد ملی")]
    public int NationalIdLogin { get; set; }
    [Display(Name = "رمز عبور")]
    public string PasswordSignup { get; set; } = string.Empty;
    [Display(Name = "رمز عبور")]
    public string PasswordLogin { get; set; } = string.Empty;
}