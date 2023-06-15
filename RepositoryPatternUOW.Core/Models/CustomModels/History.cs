using System.ComponentModel.DataAnnotations;

namespace hearing_test.Models.CustomModels
{
    public class History
    {
        public int UserId { get; set; }
        //public ApplicationUser? User { get; set; }
        public int ExamId { get; set; }
        public Exam? Exam { get; set; }
        public int QuestionId { get; set; }
        public Question? Question { get; set; }

        [MaxLength(200)]
        public string? Answer { get; set; }

        public bool IsRight { get; set; } = false;

        public DateTime Created_at { get; set; } = DateTime.Now;
    }
}
