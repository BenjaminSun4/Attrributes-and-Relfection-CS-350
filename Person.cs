using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System;
using System.Text;

namespace AttributePractice{
    public class Person {
        
        [Required]
        [FName]
        public string FirstName {get;set;}
        [PersonalInformation(1)]
        [LName]
        public string LastName { get; set; }
        [PersonalInformation(3)]
        public string SNN { get; set; }
        
        [StudentID]
        public int StudentID { get; set; }
        [GradeYear]
        public int GradeYear { get; set; }
        public Person()
        {
            FirstName="";
            LastName="";
        }
        [Obsolete]
        public Person (string fname, string lname)
        {
        FirstName = fname;
        LastName= lname;
        }
        public override string ToString()
        {
            StringBuilder List =new StringBuilder();
            Type t1 = this.GetType();
            PropertyInfo[]p =t1.GetProperties();
            foreach(MemberInfo pi in p)
            {
                List.Append($" {pi.Name}:");
                object[] attributes=pi.GetCustomAttributes(true);
                foreach(object o in attributes)
                {
                    if(o is FNameAttribute)
                    {    
                                List.Append($" {this.FirstName}\n");
                    }
                     if(o is LNameAttribute)
                    {                  
                                List.Append($" {this.LastName}\n");
                    } 
                     if(o is StudentIDAttribute)
                    {
                                StudentIDAttribute ID = (StudentIDAttribute)o;
                                List.Append($" {ID.StudentID}\n");
                    }
                     if(o is GradeYearAttribute)
                    {
                                GradeYearAttribute Year = (GradeYearAttribute)o;
                                List.Append($" {Year.GradeYear}\n");
                    }
                     if (o is PersonalInformationAttribute)
                    { 
                        PersonalInformationAttribute pia =(PersonalInformationAttribute)o;
                        if(pia.Level==3||pia.Level==2)
                        List.Append($" *****\n");
                    }
                }
                    
                }
                Console.WriteLine("_________");
                string Final =List.ToString();
                return Final;
                }
            }
            
        }

    