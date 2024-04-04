﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronics.Layers.Entities.DTO
{
    class ElectronicoBodegaDTO
    {
        public double IdElectronico { get; set; }
        public string DescripcionElectronico { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public bool Garantia { get; set; }
        public int IdBodega { get; set; }
        public string DescripcionBodega { get; set; }
        public byte[] Imagen { get; set; }
        public byte[] Documentacion { get; set; }
        public DateTime FechaInclusion { get; set; }
    }
}
