using System.ComponentModel.DataAnnotations;

namespace uniProject.Models;

public class MainFormModel
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "لطفآ اسم خود را وارد کنیید"),StringLength(50),
    Display(Name = "نام")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "لطفآ نام خانوادگی خود را وارد کنیید"),StringLength(50),
    Display(Name = "نام خانوادگی")]
    public string LastName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "لطفآ نام پدر خود را وارد کنیید"),StringLength(50),
    Display(Name = "نام پدر")]
    public string FatherName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "لطفآ کد ملی خود را وارد کنیید"),
     Display(Name = "کد ملی")]
    public int NationalId { get; set; }
    
    [Required(ErrorMessage = "لطفآ شماره شناسنامه خود را وارد کنیید"),
     Display(Name = "شماره شناسنامه")]
    public int PassPortCode { get; set; }
    
    [Required(ErrorMessage = "لطفآ جنسیت خود را وارد کنیید"),
    Display(Name = "جنسیت")]
    public int Sex { get; set; }

    [Required(ErrorMessage = "لطفآ تاریخ تولد خود را وارد کنیید"),
     Display(Name = "تاریخ تولد")]
    public string BirthDate { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "لطفآ استان تولد خود را وارد کنیید"),StringLength(50),
    Display(Name = "استان")]
    public string BirthProvince { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "لطفآ شهر تولد خود را وارد کنیید"),StringLength(50),
    Display(Name = "شهر")]
    public string BirthCity { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "لطفآ وضیعت خود را وارد کنیید"),
     Display(Name = "وضیت نظام وظیفه")]
    public int MilitaryServiceStatus { get; set; }
    
    [Required(ErrorMessage = "لطفآ مدت خدمت نظام وظیفه (ماه) خود را وارد کنیید"),
    Display(Name = "مدت خدمت نظام وظیفه (ماه)")]
    public int MilitaryServiceMonth { get; set; }

    [Required(ErrorMessage = "لطفآ تاریخ پایان خدمت و یا صدور کارت معافیت (روز، ماه، سال)  خود را وارد کنیید"),
     Display(Name = "تاریخ پایان خدمت و یا صدور کارت معافیت (روز، ماه، سال)")]
    public string MilitaryServiceEndTime { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "لطفآ دین خود را وارد کنیید"),
    Display(Name = "دین")]
    public int Religion { get; set; }
    
    [Display(Name = "داوطلب چپ دست هستم")]
    public bool LeftHandPerson { get; set; } 
    
    [Required(ErrorMessage = "لطفآ وضیعت تاهل خود را وارد کنیید"),Display(Name = "وضیعت تاهل")]
    public int MarriageStatus { get; set; }
    
    [Display(Name = "تعداد فرزند")] 
    public int? ChildCount { get; set; }
    
    [Display(Name = "شاغل قراردادی تمام وقت یا پیمانی هستم (به منظور اضافه شدن به حداکثر سن ): ")]
    public Boolean ContractWork { get; set; }

    [Display(Name = "نام سازمان")] 
    public string? ContractWorkName { get; set; } = string.Empty;
    
    [Display(Name = "ماه")]
    public int? MonthOfWork { get; set; }
    
    [Display(Name = "سال")]
    public int? YearOfWork { get; set; }
    
    [Display(Name = "دارای پایان طرح اجباری برای فارغ التحصیلان رسته بهداشتی و درمانی و پزشکان")]
    public Boolean MedicineWork { get; set; }

    [Display(Name = "نام سازمان"),StringLength(50)] 
    public string? MedicineWorkName { get; set; } = string.Empty;
    
    [Display(Name = "ماه")]
    public int? MonthOfMedicine { get; set; }
    
    [Display(Name = "سال")]
    public int? YearOfMedicine { get; set; }

    [Display(Name = "مدت حضور داوطلبانه در جبهه های نبرد حق علیه باطل به میزان مدت حضور داوطلبانه در جبهه")]
    public string? WarTime { get; set; } = string.Empty;

    [Display(Name =
     "مدت اسارت در مورد داوطلبانی که در طول جنگ تحمیلی در اسارت دشمن بعثی و یا گروه های ضد انقلاب بوده اند به میزان مدت اسارت و حضور در جبهه")]
    public string? CaptiveTime { get; set; } = string.Empty;

    [Display(Name =
     "مدت زمان بستری شدن و یا استراحت پزشکی رزمندگان داوطلب در اثر مجروحیت در جبهه های نبرد حق علیه باطل به میزان مدت بستری")]
    public string? InjuredTime { get; set; } = string.Empty;
    
    [Display(Name = "افراد خانواده شهداء بمیزان 5 سال به شرح ذیل")] 
    public int? FamilyWarHeroMember { get; set; }
    
    [Display(Name = "مشمولین معاف از شرط سنی  به شرط ارائه مدارک از طرف بنیاد شهید و امور ایثارگران")] 
    public int? AgeExceptionCondition { get; set; }
    
    [Display(Name = "مقطع تحصیلی")] 
    public int? EducationLevel { get; set; }
    
    [Display(Name = "عنوان رشته تحصیلی")]
    public string? EducationTitle { get; set; } = string.Empty;
    
    [Display(Name = "دانشگاه یا موسسه محل تحصیل")]
    public string? EducationSchool { get; set; } = string.Empty;

    [Display(Name = "تاریخ فراغت از تحصیل (روز، ماه، سال)")]
    public string? EducationEndTime { get; set; } = string.Empty;
    
    [Display(Name = "شماره تلفن ثابت"),StringLength(50)] 
    public string? HomePhoneNumber { get; set; } = string.Empty;

    [Display(Name = "شماره تلفن همراه"),StringLength(12), 
     Required(ErrorMessage = "لطفا شماره همراه خود را وارد کنیید")] 
    public string PhoneNumber { get; set; } = string.Empty;
    
    [Display(Name = "کد پستی ده رقمی"),
     Required(ErrorMessage = "لطفا کد پستی خود را وارد کنیید")] 
    public int CodePost { get; set; }
    
    [Display(Name = "آدرس پست الکترونیکی (Email)"),StringLength(50)] 
    public string? Email { get; set; } = string.Empty;
    
    [Display(Name = "آدرس محل سکونت"),StringLength(50)] 
    public string? Address { get; set; } = string.Empty;
    
    [Display(Name = "عنوان رشته شغل مورد تقاضا"),StringLength(50)] 
    public string? WantedJobTitle { get; set; } = string.Empty;
    
    [Display(Name = "استان"),StringLength(50)] 
    public string? LocalProvince { get; set; } = string.Empty;
    
    [Display(Name = "شهرستان"),StringLength(50)] 
    public string? LocalCity { get; set; } = string.Empty;
    
    [Display(Name = "یکسان بودن شهرستان محل تولد داوطلب با شهرستان مورد تقاضا")] 
    public Boolean SameLocalPlace { get; set; }
    
    [Display(Name = "ساکن بودن و حداقل ده سال سابقه سکونت در شهرستان مورد تقاضا با ارایه استشهاد محلی ممهور به مهر نیروی انتظامی (پاسگاه یا کلانتری محل)")] 
    public Boolean ConfirmLocalCity { get; set; }

    public long? TrackingId { get; set; }
}