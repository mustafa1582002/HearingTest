using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RepositoryPatternUOW.Core.Models.CustomModels
{
    public class History
    {
        public int UserId { get; set; }
        //public ApplicationUser? User { get; set; }
        public int ExamId { get; set; }
        [JsonIgnore]
        public Exam Exam { get; set; }
        public int QuestionId { get; set; }
        [JsonIgnore]
        public Question Question { get; set; }

        [MaxLength(200)]
        public string? Answer { get; set; }

        public bool IsRight { get; set; } = false;

        public DateTime Created_at { get; set; } = DateTime.Now;
    }
}
