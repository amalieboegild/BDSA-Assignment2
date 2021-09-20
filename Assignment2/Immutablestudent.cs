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
            get; init;
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
