using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaElectronica.CFDI33
{
    public partial class ComprobanteImpuestosTraslado
    {
        /// <summary>
        /// Atributo condicional para señalar el importe del impuesto trasladado que aplica al concepto. No se permiten valores negativos. Es requerido cuando TipoFactor sea Tasa o Cuota
        /// </summary>
        [XmlIgnore]
        public t_Importe Importe { set; get; }
    }
}
