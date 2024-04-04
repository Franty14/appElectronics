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
    class BLLFactura : IBLLFactura
    {
        public int GetNextNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetNextNumeroFactura();
        }

        public int GetCurrentNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetCurrentNumeroFactura();
        }

        public FacturaEncabezado SaveFactura(FacturaEncabezado pFactura)
        {
            IDALFactura _DALFactura = new DALFactura();
            IBLLElectronico _IBLLElectronico = new BLLElectronico();

            // Vuelve a validar que exista en inventario
            foreach (FacturaDetalle oFacturaDetalle in pFactura._ListaFacturaDetalle)
            {
                _IBLLElectronico.AvabilityStock(oFacturaDetalle.IdElectronico, oFacturaDetalle.Cantidad); 
            }

            return _DALFactura.SaveFactura(pFactura);  
        }


        public double GetTotalFactura(double pIdFactura) {
            DALFactura _DALFactura = new DALFactura();
            
            return _DALFactura.GetTotalFactura(pIdFactura);

        }

    }
}
