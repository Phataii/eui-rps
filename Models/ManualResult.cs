namespace rps.Models
{
    public class ManualResult
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public string? MatNumber { get; set; }
        public string? Faculty { get; set; }
        public string? Department { get; set; }
        public string? Session { get; set; }
        public string? CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Credit { get; set; }
        public string? Grade { get; set; }
        public string? Semester { get; set; }
        public string? Unit { get; set; }
        public string? UploadedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}