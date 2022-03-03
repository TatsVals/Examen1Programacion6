using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{ 
    public class VehiculoEntity : DBEntity
    {
        public int IdVehiculo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Valor { get; set; }
        public string Estado { get; set; }
    }
}
