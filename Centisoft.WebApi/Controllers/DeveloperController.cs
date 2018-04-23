using Centisoft.Core.Contracts;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Centisoft.WebApi.Controllers
{
    public class DeveloperController : ApiController
    {
        // WARNING this does not currently work
        public IDeveloperFacade developerFacade;
        //public DeveloperController(IDeveloperFacade developerFacade)
        //{
        //    this.developerFacade = developerFacade;

        //}
        // GET: api/Developer
        [Filters.MigHeader]
        public List<Developer> Get()
        {
            return developerFacade.FindAllDevelopers();
        }

        // GET: api/Developer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Developer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Developer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Developer/5
        public void Delete(int id)
        {
        }
    }
}
