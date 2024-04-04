using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Interfaces
{
    interface IBLLFactura
    {
        FacturaEncabezado SaveFactura(FacturaEncabezado pFactura);
       
        int GetNextNumeroFactura();

        int GetCurrentNumeroFactura();
    }
}
