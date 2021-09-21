using System;

namespace Assignment2
{
    public class Student
    {
        public int Id { get; init; }

        public string GivenName { get; set; }

        public string Surname { get; set; }
        public Status Status 
        { 
            get
            {
                DateTime now = DateTime.Now;
                if(StartDate>now){
                    return Status.New;
                } else if(StartDate<now && now<EndDate){
                    return Status.Active;
                } else if(GraduationDate==EndDate && now>=EndDate){
                    return Status.Graduated;    
                } else if(GraduationDate>EndDate){
                    return Status.Dropout;
                } else{
                    return Status.Active;
                }
            } 
        }
        
        public DateTime StartDate{get; set;}
        
        
        public DateTime EndDate{get; set;}
        public DateTime GraduationDate{get; set;}
        

        public override string ToString()
        {
            return "Id and name: " + Id + " " + GivenName+ " " + Surname + ". Status: " + Status + ", Startdate: " + StartDate + " Enddate: " + EndDate + " Graduationdate: " + GraduationDate;
        } 
    }
}
