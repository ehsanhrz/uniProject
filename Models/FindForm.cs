using System.ComponentModel.DataAnnotations;

namespace uniProject.Models;

public class FindForm
{
    [Required(ErrorMessage = "لطفا شماره رهگیری را وارد کنید"),
     Display(Name = "شماره رهگیری")]
    public long TrackingId { get; set; }
}