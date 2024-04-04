using System;
using System.Collections.Generic;

using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.BLL
{
    class BLLCliente : IBLLCliente
    {
        public List<Cliente> GetClienteByFilter(string pDescripcion)
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetClienteByFilter(pDescripcion);
        }

        public Cliente GetClienteById(string pIdCliente)
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetClienteById(pIdCliente);
        }


        public List<Cliente> GetAllCliente()
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetAllCliente();
        }

        public Cliente SaveCliente(Cliente pCliente)
        {
            IDALCliente _DALCliente = new DALCliente();
            Cliente oCliente = null;              

            if (_DALCliente.GetClienteById(pCliente.IdCliente) == null)
                oCliente = _DALCliente.SaveCliente(pCliente);
            else
                oCliente = _DALCliente.UpdateCliente(pCliente); 

            return oCliente;
        }

        public bool DeleteCliente(string pId)
        {
            IDALCliente _DALCliente = new DALCliente();

            return _DALCliente.DeleteCliente(pId);

        }
    }
}
