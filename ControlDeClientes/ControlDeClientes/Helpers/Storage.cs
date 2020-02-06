using ControlDeClientes.Models;
using System.Collections.Generic;

namespace ControlDeClientes.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null )
                {
                    _instance = new Storage();
                }
                return _instance;
            }
        }
        public string Type;
        public List<ClientsModel> ClientsList = new List<ClientsModel>();
        public List<ClientsModel> ClientsSortedByName = new List<ClientsModel>();
        public List<ClientsModel> ClientsSortedByLastName = new List<ClientsModel>();
    }
}