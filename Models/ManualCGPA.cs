namespace rps.Models
{
    public class ManualCGPA
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? ResultId { get; set; }
        public double? CGPA { get; set;}
        public double? GPA { get; set;} 
        public DateTime CreatedAt { get; set; }
    }
}