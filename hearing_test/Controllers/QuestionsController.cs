using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternUOW.Core.interfaces;
using RepositoryPatternUOW.Core.Models.CustomModels;

namespace hearing_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IBaseRepo<Question> _questionRepo;
        public QuestionsController(IBaseRepo<Question> questionRepo)
        {
            _questionRepo = questionRepo;
        }

        [HttpGet("GetById")]
        public IActionResult GetById()
        {
            return Ok(_questionRepo.GetById(2));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_questionRepo.GetAll());
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName(string Name)
        {
            return Ok(_questionRepo.Find(b => b.Name == Name, new[] { "Question_History" } ));
        }
        [HttpPost("AddOne")]
        public IActionResult AddOne()
        {
            return Ok(_questionRepo.Add(new Question { Audio ="test", RightAnswer ="third", Wrong1 ="one", Wrong2 ="two", Wrong3 ="four",Name="how to easy develop",Description="clean code",Created_at=DateTime.Now}));
        }
        /*[HttpPost("AddRange")]
        public IActionResult AddRange()
        {
            return Ok(_questionRepo.AddRange(new Question { Audio ="test", RightAnswer ="third", Wrong1 ="one", Wrong2 ="two", Wrong3 ="four",Name="how to easy develop",Description="clean code",Created_at=DateTime.Now}));
        }*/

    }
}
