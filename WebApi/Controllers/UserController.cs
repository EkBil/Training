using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Models;

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
        private IList<User> Users
        {
            get
            {
                List<User> listUser = new List<User>{
                    new User { Id=1, FirstName="El Khattouti", LastName="Bilal", Email="b.elkhattouti@students.ephec.be" },
                    new User { Id=2, FirstName="El Khattouti", LastName="Deuxter", Email="b.elkhattouti@students.ephec.be" },
                    new User { Id=3, FirstName="El Khattouti", LastName="Tromat", Email= "b.elkhattouti@students.ephec.be" }
                };
                return listUser;
            }
        }

        // GET: api/User
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Users);
        }

        // GET: api/User/5
        public HttpResponseMessage Get(int id)
        {
            User usr = Users.Where(x => x.Id == id).First();
            if (usr == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            return Request.CreateResponse(HttpStatusCode.OK, usr);
        }

        // POST: api/User
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse(HttpStatusCode.OK,value);
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
