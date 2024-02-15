using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NajotTalimCRMDapper.Entities.DTOs;
using NajotTalimCRMDapper.MyPettern;

namespace NajotTalimCRMDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepo;

        public StudentsController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpPost]
        public IActionResult CreateStudentwejrqeoruyqe(StudentDTO model)
        {
            try
            {
                var response = _studentRepo.CreateStudent(model);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAllStudentsFromMyDatabse()
        {
            try
            {
                var response = _studentRepo.GetAllStudents();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
