using System;
public class FNameAttribute : Attribute
    {
        public string FirstName {get;set;}    
    }

public class LNameAttribute: Attribute
    {
        public string LastName{get;set;}
    }