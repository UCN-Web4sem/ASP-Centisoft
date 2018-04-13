using Centisoft.Core.BLL;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Centisoft.WebApi.Controllers
{
    public class ClientController : ApiController
    {
        private ClientFacade clientFacade;

        public ClientController()
        {
            this.clientFacade = new ClientFacade();
        }
        // GET: api/Client
        public List<Client> Get()
        {
            return clientFacade.FindAllClients();
        }

        // GET: api/Client/5
        public Client Get(int id)
        {
            return clientFacade.FindClient(id);
        }

        // POST: api/Client
        public void Post([FromBody]Client client)
        {
            clientFacade.CreateClient(client);
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]Client client)
        {
            Client oldCLient = clientFacade.FindClient(id);
            oldCLient.Name = client.Name;
            oldCLient.Token = client.Token;
            oldCLient.Customers = client.Customers;
            clientFacade.UpdateClient(oldCLient);
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
            clientFacade.DeleteClient(id);
        }
    }
}
