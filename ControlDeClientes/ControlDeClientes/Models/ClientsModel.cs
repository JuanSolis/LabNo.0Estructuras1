using ControlDeClientes.Helpers;
using System.Collections.Generic;
namespace ControlDeClientes.Models
{
    public class ClientsModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Description { get; set; }


        public bool Save()
        {
            try
            {
                Storage.Instance.ClientsList.Add(this);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool SortName()
        {
            try
            {
                List<ClientsModel> ClientsToSort = new List<ClientsModel>();


                foreach (ClientsModel Client in Storage.Instance.ClientsList)
                {
                    ClientsToSort.Add(Client);
                }

                var temp = new ClientsModel();
                for (int j = 0; j <= ClientsToSort.Count - 2; j++)
                {

                    for (int i = 0; i <= ClientsToSort.Count - 2; i++)
                    {
                        int responseCompareTo = ClientsToSort[i].Name.CompareTo(ClientsToSort[i + 1].Name);

                        if (responseCompareTo > 0)
                        {
                            temp = ClientsToSort[i + 1];
                            ClientsToSort[i + 1] = ClientsToSort[i];
                            ClientsToSort[i] = temp;
                        }
                    }
                }

                if (Storage.Instance.ClientsSortedByName.Count > 0)
                {
                    Storage.Instance.ClientsSortedByName.Clear();
                }

                foreach (ClientsModel ClientSorted in ClientsToSort)
                {
                    Storage.Instance.ClientsSortedByName.Add(ClientSorted);
                }

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

        public bool SortLastName()
        {
            try
            {
                List<ClientsModel> ClientsToSort = new List<ClientsModel>();

                if (ClientsToSort.Count > 0)
                {
                    ClientsToSort.Clear();
                }

                foreach (ClientsModel Client in Storage.Instance.ClientsList)
                {
                    ClientsToSort.Add(Client);
                }

                var temp = new ClientsModel();
                for (int j = 0; j <= ClientsToSort.Count - 2; j++)
                {

                    for (int i = 0; i <= ClientsToSort.Count - 2; i++)
                    {
                        int responseCompareTo = ClientsToSort[i].LastName.CompareTo(ClientsToSort[i + 1].LastName);

                        if (responseCompareTo > 0)
                        {
                            temp = ClientsToSort[i + 1];
                            ClientsToSort[i + 1] = ClientsToSort[i];
                            ClientsToSort[i] = temp;
                        }
                    }
                }

                if (Storage.Instance.ClientsSortedByLastName.Count > 0)
                {
                    Storage.Instance.ClientsSortedByLastName.Clear();
                }

                foreach (ClientsModel ClientSorted in ClientsToSort)
                {
                    Storage.Instance.ClientsSortedByLastName.Add(ClientSorted);
                }

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }


    }
}