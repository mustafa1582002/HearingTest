﻿using System.ComponentModel.DataAnnotations;

namespace hearing_test.Models.CustomModels
{
    public class Question : Base
    {
        [MaxLength(500)]
        public string Audio { get; set; }

        [MaxLength(200)]
        public string RightAnswer { get; set; }

        [MaxLength(200)]
        public string Wrong1 { get; set; }

        [MaxLength(200)]
        public string Wrong2 { get; set; }

        [MaxLength(200)]
        public string Wrong3 { get; set; }

        public ICollection<ExamQuestion> Questions { get; set; } = new List<ExamQuestion>();

        public ICollection<History> Question_History { get; set; } = new List<History>();

    }
}
