using System;


namespace AttributePractice{

    public class StudentIDAttribute : Attribute
    {
        Random random = new Random ();
public int StudentID { get; set; }
public StudentIDAttribute()
{
 StudentID= random.Next(00000, 99999);

}
    }
}