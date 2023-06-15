using System.ComponentModel.DataAnnotations;

namespace uniProject.Models;

public class UserModel
{
    [Key] 
    public Guid Id { get; set; }
    [Required(ErrorMessage = "لطفا کد ملی را وارد کنیید")]
    public int NationalId { get; set; }
    [Required(ErrorMessage = "لطفا رمز عبور خود  را وارد کنیید")]
    public string Password { get; set; }
    
}