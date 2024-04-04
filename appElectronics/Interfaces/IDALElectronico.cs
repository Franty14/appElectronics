using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Interfaces
{
    interface IDALElectronico
    {
        Electronico GetElectronicoById(double pId);
        List<ElectronicoBodegaDTO> GetAllElectronico();
        List<Electronico> GetElectronicoByFilter(string pDescripcion);
        Electronico SaveElectronico(Electronico pElectronico);
        Electronico UpdateElectronico(Electronico pElectronico);
        bool DeleteElectronico(double pId);
       

    }
}
