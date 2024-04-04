using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.BLL
{
    class BLLTarjeta : IBLLTarjeta
    {
        public bool DeleteTarjeta(int pId)
        {
            throw new NotImplementedException();
        }

        public List<Tarjeta> GetAllTarjeta()
        {
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            return _DALTarjeta.GetAllTarjeta();
        }

        public Tarjeta GetTarjetaById(string pIdTarjeta)
        {
            throw new NotImplementedException();
        }

        public Tarjeta SaveTarjeta(Tarjeta pTarjeta)
        {
            throw new NotImplementedException();

        }
    }
}
