using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Layers.BLL
{
    class BLLElectronico : IBLLElectronico
    {
        public bool DeleteElectronico(double pId)
        {
            IDALElectronico _IDALElectronico = new DALElectronico();
            return _IDALElectronico.DeleteElectronico(pId);
        }

        public List<ElectronicoBodegaDTO> GetAllElectronico()
        {
            IDALElectronico _IDALElectronico = new DALElectronico();
            return _IDALElectronico.GetAllElectronico();

        }

        public List<Electronico> GetElectronicoByFilter(string pDescripcion)
        {
            IDALElectronico _IDALElectronico = new DALElectronico();
            return _IDALElectronico.GetElectronicoByFilter(pDescripcion);
        }

        public Electronico GetElectronicoById(double pId)
        {
            IDALElectronico _IDALElectronico = new DALElectronico();
            return _IDALElectronico.GetElectronicoById(pId);
        }

        public Electronico SaveElectronico(Electronico pElectronico)
        {
            IDALElectronico _IDALElectronico = new DALElectronico();
            Electronico oElectronico = null;
            if (_IDALElectronico.GetElectronicoById(pElectronico.IdElectronico) == null)
                oElectronico = _IDALElectronico.SaveElectronico(pElectronico);
            else
                oElectronico = _IDALElectronico.UpdateElectronico(pElectronico);

            return oElectronico;
        }


        /// <summary>
        /// VAlida la cantidad disponible en inventario
        /// </summary>
        /// <param name="pId">Codigo del artículo</param>
        /// <param name="pCantidadSolicitada">Cantidad solicitada</param>
        /// <returns></returns>
        public Electronico AvabilityStock(double pId, double pCantidadSolicitada)
        {
            IDALElectronico _IDALElectronico = new DALElectronico();
            Electronico oElectronico = _IDALElectronico.GetElectronicoById(pId);

            if (oElectronico.Cantidad < pCantidadSolicitada)
                throw new Exception($"No hay cantidad suficiente en inventario para el producto {oElectronico.IdElectronico} {oElectronico.DescripcionElectronico}, cantidad disponible: {oElectronico.Cantidad}");
            else
                return oElectronico;
        }
    }
}
