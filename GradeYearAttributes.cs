using System;


namespace AttributePractice{

    public class GradeYearAttribute : Attribute
    {
        Random random = new Random ();
public int GradeYear { get; set; }
public GradeYearAttribute()
{
 GradeYear= random.Next(1, 12);

}
    }
}