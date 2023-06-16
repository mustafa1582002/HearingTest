using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternUOW.Core.interfaces;
using RepositoryPatternUOW.Core.Models.CustomModels;

namespace hearing_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IBaseRepo<Exam> _examRepo;
        public ExamsController(IBaseRepo<Exam> examRepo)
        {
            _examRepo = examRepo;
        }

        [HttpGet("GetById")]
        public IActionResult GetById()
        {
            return Ok(_examRepo.GetById(1));
        }
        [HttpGet("GetByIdWithQuestion")]
        public IActionResult GetByIdWithQuestion()
        {
            return Ok(_examRepo.GetById(1));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_examRepo.GetAll());
        }


        //, new[] { "ExamQuestion" }have a problem with including self refrence looping in Exam_History
        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_examRepo.Find(b=>b.Name=="hring1", new[] { "Exams", "Exam_History" }));
        }
        [HttpGet("GetAllWithQuestion")]
        public IActionResult GetAllWithQuestion()
        {
            return Ok(_examRepo.FindAll(b => b.Num_of_questions == 5, new[] { "Exams", "Exam_History" }));
        }  

    }
}
