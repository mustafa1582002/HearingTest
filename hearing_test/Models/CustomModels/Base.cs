using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace hearing_test.Models.CustomModels
{
    [Index(nameof(Name), IsUnique = true)]
    public class Base
    {
        public int id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Created_at { get; set; } = DateTime.Now;

        public DateTime LastUpdated_at { get; set; } = DateTime.Now;
    }
}
