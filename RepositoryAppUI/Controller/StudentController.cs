using BLL.Operation.Implementations;
using BLL.Operation.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;

namespace RepositoryAppUI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;

        }

        [HttpGet]
        public List<Student> Get()
        {
            return _studentService.GetAll();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _studentService.GetById(id);
        }

        [HttpPost]
        public Student Post([FromBody] Student student)
        {
          _studentService.Add(student);
            return student;
        }

        [HttpPut]

        public Student Put([FromBody] Student student)
        {
           _studentService.Update(student);
            return student;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _studentService.Delete(id);
        }

    }
}
