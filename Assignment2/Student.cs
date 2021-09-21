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
                if(StartDate>DateTime.Now){
                    return Status.New;
                } else if(StartDate<DateTime.Now && DateTime.Now<EndDate){
                    return Status.Active;
                } else if(GraduationDate==EndDate && DateTime.Now>=EndDate){
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
