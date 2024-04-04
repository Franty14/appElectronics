using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Interfaces
{
    interface IDALTarjeta
    {
        List<Tarjeta> GetAllTarjeta();
        Tarjeta GetTarjetaById(int pIdTarjeta);
        Tarjeta SaveTarjeta(Tarjeta pTarjeta);
        bool DeleteTarjeta(string pId);
        Tarjeta UpdateTarjeta(Tarjeta pTarjeta);
    }
}
