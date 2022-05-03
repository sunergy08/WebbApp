using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebbApp.Context;
using WebbApp.Models;

namespace WebbApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private StudentContext _studentContext;

        public StudentController(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentContext.Students;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _studentContext.Students.FirstOrDefault(s => s.StudentId == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            _studentContext.Students.Add(value);
            _studentContext.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            var student = _studentContext.Students.FirstOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                _studentContext.Entry<Student>(student).CurrentValues.SetValues(value);
                _studentContext.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _studentContext.Students.FirstOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                _studentContext.Students.Remove(student);
                _studentContext.SaveChanges();
            }
        }
    }

}

