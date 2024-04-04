using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Interfaces
{
      
    interface IBLLCliente
    {
        List<Cliente> GetClienteByFilter(string pDescripcion);
        Cliente GetClienteById(string pIdCliente);
        List<Cliente> GetAllCliente();
        Cliente SaveCliente(Cliente pCliente);
        bool DeleteCliente(string pId);

    }
}
