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
    class BLLProvincia : IBLLProvincia
    {
        public List<Provincia> GetAllProvincia()
        {
            IDALProvincia _DALProvincia = new DALProvincia();

            return _DALProvincia.GetAllProvincia();

        }
    }
}
