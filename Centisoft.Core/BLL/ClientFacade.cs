using Centisoft.Core.DAL;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.BLL
{
    public class ClientFacade
    {
        private ClientRepo ClientRepo;
        public ClientFacade()
        {
            ClientRepo = new ClientRepo();
        }

        public void CreateClient(Client Client)
        {
            ClientRepo.Save(Client);
        }

        public void DeleteClient(int id)
        {
            ClientRepo.Delete(id);
        }

        public Client FindClient(int id)
        {
            return ClientRepo.Load(id);
        }

        public List<Client> FindAllClients()
        {
            return ClientRepo.LoadAll();
        }

        public void UpdateClient(Client Client)
        {
            ClientRepo.Save(Client);
        }
    }
}
