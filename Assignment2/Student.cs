using System;

namespace Assignment2
{
    public class Student
    {
        public int Id { get; init; }

        public string GivenName { get; set; }

        public string Surname { get; set; }
        public Status Status { get; set; }
        
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public DateTime GraduationDate{get; set;}
        

        public override string ToString()
        {
            return "Id and name: " + Id + " " + GivenName+ " " + Surname + ". Status: " + Status + ", Startdate: " + StartDate + " Enddate: " + EndDate + " Graduationdate: " + GraduationDate;
        }
    }
}
