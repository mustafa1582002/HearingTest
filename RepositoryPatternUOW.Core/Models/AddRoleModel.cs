
using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternUOW.Core.Models
{
    public class AddRoleModel
    {
        
        public string UserId { get; set; }
        
        public string Role { get; set; }
    }
}
