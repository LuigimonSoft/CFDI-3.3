using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaElectronica.CFDI33.Complementos
{
    public partial class PagosPagoImpuestos
    {
        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos retenidos que se desprenden del pago. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe TotalImpuestosRetenidos { get; set; }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos trasladados que se desprenden del pago. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe TotalImpuestosTrasladados { set; get; }
    }
}
