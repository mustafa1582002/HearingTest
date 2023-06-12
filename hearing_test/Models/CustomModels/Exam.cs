namespace hearing_test.Models.CustomModels
{
    public class Exam : Base
    {
        public int Num_of_questions { get; set; }

        public ICollection<ExamQuestion> Exams { get; set; } = new List<ExamQuestion>();

        public ICollection<History> Exam_History { get; set; } = new List<History>();
    }
}
