using System;

namespace Factory.DTO
{
    public class SchoolAverage
    {
        public int NumberOfStudents { get; set; }
        public int AgeRangeOfStudents { get; set; }

        public override string ToString()
            => $"Number of students: {NumberOfStudents}\n" 
                + $"Age range of students: {AgeRangeOfStudents}\n";        
    }
}
