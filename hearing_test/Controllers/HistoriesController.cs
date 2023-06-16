using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternUOW.Core.interfaces;
using RepositoryPatternUOW.Core.Models.CustomModels;

namespace hearing_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriesController : ControllerBase
    {
        private readonly IBaseRepo<History> _historRepo;
        public HistoriesController(IBaseRepo<History> historRepo)
        {
            _historRepo = historRepo;
        }

        [HttpGet("GetById")]//null err
        public IActionResult GetById()
        {
            return Ok(_historRepo.GetById(1));
        }
        [HttpGet("GetAllWithQuestion")]
        public IActionResult GetAllWithQuestion()
        {
            return Ok(_historRepo.FindAll(b => b.Answer == "one", new[] { "Question", "Exam" } ));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_historRepo.GetAll());
        }
        [HttpGet("GetByAnswer")]
        public IActionResult GetByAnswer(string Answer)
        {
            return Ok(_historRepo.Find(b => b.Answer == Answer));
        }
    }
}
