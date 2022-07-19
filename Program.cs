using System;
using System.Reflection;
using System.Collections.Generic;

namespace AttributePractice
{
    class Program
    {
        static void Main(string[] args)
        {

         
            Console.WriteLine("Hello World!");
            Person p1 =new Person()
            {
                FirstName = "Bob",
                LastName = "Smith"
            };
            Person p2 =new Person()
            {
                FirstName = "Jack",
                LastName = "Ripper"
            };
            Person p3 =new Person()
            {
                FirstName = "Jeffrey",
                LastName = "Dahmer"
            };
            Person p4 =new Person()
            {
                FirstName = "Harold",
                LastName = "Shipman"
            };
            Person p5 =new Person()
            {
                FirstName = "John",
                LastName = "Gacy"
            };
            List<Person> person = new List<Person>()
            {
                p1,p2,p3,p4,p5
            };
            foreach (Person p in person)
           {
               System.Console.WriteLine(p);
           }

            System.Console.WriteLine("\n");
            /*
            Type t1 = p1.GetType();

            System.Console.WriteLine(t1);

        
              MemberInfo [] m = t1.GetMembers();
            foreach(MemberInfo mi  in m )
            {
            System.Console.WriteLine(mi);
            object[] attributes = mi.GetCustomAttributes(true);
            foreach(object o in attributes)
            {
                System.Console.WriteLine(o);
                if(o is PersonalInformationAttribute)
                {
                    System.Console.WriteLine("Personal - Dont't print");
                    PersonalInformationAttribute pia  = (PersonalInformationAttribute)o;
                    if (pia.Level ==3)
                    System.Console.WriteLine("super private");
                    else
                    System.Console.WriteLine("sort of Private");
                }

            }
              


            System.Console.WriteLine("____________________________");
            }
              */
   
}
    }
}
