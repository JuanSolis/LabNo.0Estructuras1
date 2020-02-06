using System;
using System.Collections.Generic;
using ControlDeClientes.Helpers;
using System.Linq;
using System.Web;

namespace ControlDeClientes.Models
{
    public class FilterModel
    {
        public string TypeSort { get; set; }


        public bool Save()
        {
            try
            {
                Storage.Instance.Type = this.TypeSort;
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

       

    }
}