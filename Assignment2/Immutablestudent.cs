using System;

namespace Assignment2
{
    public record Immutablestudent
    {
        public int Id { get; init; }

        public string GivenName { get; init; }

        public string Surname { get; init; }
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
        
        public DateTime StartDate{get; init;}
        public DateTime EndDate{get; init;}
        public DateTime GraduationDate{get; init;}
        

        public override string ToString()
        {
            return "Id and name: " + Id + " " + GivenName+ " " + Surname + ". Status: " + Status + ", Startdate: " + StartDate + " Enddate: " + EndDate + " Graduationdate: " + GraduationDate;
        }
    }
}
