using System.ComponentModel.DataAnnotations;

namespace uniProject.Models;

public enum Sex
{
    [Display(Name = "مرد")]
    Male,
    [Display(Name = "زن")]
    Female
}

public enum MilitaryStatus
{
    [Display(Name = "کارت پایان خدمت ")]
    EndServiceCard,
    [Display(Name = "کارت معافیت دائم")]
    ServiceException
}

public enum Religion
{
    [Display(Name = "اسلام")]
    Islam,
    [Display(Name = "کلیمی")]
    Kelimi,
    [Display(Name = "مسیحی")]
    Masihi,
    [Display(Name = "زرتشتی")]
    Zartoshti
}

public enum  MarriageStatus
{
    [Display(Name = "مجرد")]
    Single,
    [Display(Name = "متاهل")]
    Married
}

public enum FamilyMemberWarHero
{
    [Display(Name = "همسر")]
    Spouse,
    [Display(Name = "پدر")]
    Father,
    [Display(Name = "مادر")]
    Mother,
    [Display(Name = "برادر")]
    Brother,
    [Display(Name = "خواهر")]
    Sister
}

public enum MilitaryException
{
    [Display(Name = "فرزندان شاهد")]
    ShahedKid,
    [Display(Name = "جانبازان از کار افتاده کلی و فرزندان")]
    Janbaz,
    [Display(Name = "آزادگان از کار افتاده کلی و فرزندان")]
    FreeMans
}


public enum EducationLevel
{
    [Display(Name = "لیسانس")]
    Bachelor,
    [Display(Name = "فوق لیسانس")]
    MasterOfArt,
    [Display(Name = "دکتری")]
    Phd,
    [Display(Name = "فوق دکتری")]
    PostPhd
}