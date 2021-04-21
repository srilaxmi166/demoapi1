using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Context;
using WebApplication3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;

        public ValuesController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _CRUDContext.Students;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _CRUDContext.Students.SingleOrDefault(x => x.StudentId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _CRUDContext.Students.Add(student);
            _CRUDContext.SaveChanges();

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Student student)
        {
            student.StudentId = id;
            _CRUDContext.Students.Update(student);
            _CRUDContext.SaveChanges();

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Students.FirstOrDefault(x => x.StudentId == id);
            if(item!=null)
            {
                _CRUDContext.Students.Remove(item);
                _CRUDContext.SaveChanges();
             
            }
        }
    }
}
