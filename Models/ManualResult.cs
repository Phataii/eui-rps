namespace rps.Models
{
    public class ManualResult
    {
        public int Id { get; set; }
        public string UploadedBy { get; set; }
        public string Name { get; set; }
        public string MatNumber { get; set; }
        public int Faculty { get; set; }
        public string Department { get; set; }
        public int Level { get; set; }
        public int Session { get; set; }
        public int Semester { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public int Credit { get; set; }
        public string Grade { get; set; }
        public double GradePoint { get; set; }
        public double GPA { get; set; }
        public double CGPA { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}