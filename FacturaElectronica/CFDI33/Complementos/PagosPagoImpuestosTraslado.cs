using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaElectronica.CFDI33.Complementos
{
    public partial class PagosPagoImpuestosTraslado
    {
        /// <summary>
        /// Atributo requerido para señalar el importe del impuesto trasladado. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe Importe { set; get; }
    }
}
