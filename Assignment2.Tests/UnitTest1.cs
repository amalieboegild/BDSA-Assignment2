using System;
using Xunit;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Student_ToString()
        {
            var start = new DateTime(2020,8,8);
            var end = new DateTime(2023,6,3);
            var graduation = new DateTime(2023,6,25);
            var s = new Student{
                Id = 22,
                GivenName = "Amalie",
                Surname = "Bøgild",
                Status = Status.Active,
                StartDate = new DateTime(2020,8,8),
                EndDate = new DateTime(2023,6,3),
                GraduationDate = new DateTime(2023,6,25)
            };
            string expected = "Id and name: 22 Amalie Bøgild. Status: Active, Startdate: 08/08/2020 00.00.00 Enddate: 03/06/2023 00.00.00 Graduationdate: 25/06/2023 00.00.00";
            string actual = s.ToString();
            Assert.Equal(expected,actual);
        }
    }
}
