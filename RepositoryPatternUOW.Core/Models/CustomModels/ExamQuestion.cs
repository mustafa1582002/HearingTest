using System.Text.Json.Serialization;

namespace RepositoryPatternUOW.Core.Models.CustomModels
{
    public class ExamQuestion
    {
        public int ExamId { get; set; }
        [JsonIgnore]
        public Exam? Exam { get; set; }
        public int QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
