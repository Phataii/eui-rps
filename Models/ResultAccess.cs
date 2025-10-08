// Models/ResultAccess.cs
namespace rps.Models
{
    public class ResultAccess
    {
        public int Id { get; set; }
        public string MatNumber { get; set; }
        public string CodeHash { get; set; }  // Hashed code (not plaintext)
        public string Code { get; set; }
        public bool Published { get; set; } = false;
            // Active session info
        public string? CurrentSessionToken { get; set; }   // session token issued after code verification
        public DateTime? SessionExpiry { get; set; }       // when that session expires
        public DateTime? LastUsed { get; set; }            // last time student accessed results

        public DateTime CodeExpiry { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}