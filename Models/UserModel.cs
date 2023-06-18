using System.ComponentModel.DataAnnotations;

namespace uniProject.Models;

public class UserModel
{
    [Key] 
    public Guid Id { get; set; }

    [Required(ErrorMessage = "لطفا کد ملی را وارد کنیید"), Display(Name = "کد ملی")]
    public string NationalId { get; set; } = string.Empty;

    [Required(ErrorMessage = "لطفا رمز عبور خود  را وارد کنیید"), Display(Name = "رمز عبور")]
    [StringLength(255, ErrorMessage = "رمز عبور حداقل باید 8 کاراکتر داشته باشد", MinimumLength = 8)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

}
