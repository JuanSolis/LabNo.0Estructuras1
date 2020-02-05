using ControlDeClientes.Helpers;

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
    }
}