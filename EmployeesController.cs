using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeChallenge1.Controllers
{
    public class EmployeesController : ApiController
    {
        private EmployeeRepository _empRepository;
        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            return new List<Employee>();
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
           return _empRepository.GetEmployeeById(id);
         
        }

        // POST api/<controller>
        public void Post([FromBody]Employee empInfo)
        {
            var result = _empRepository.SaveEmployee(empInfo);

        }

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}