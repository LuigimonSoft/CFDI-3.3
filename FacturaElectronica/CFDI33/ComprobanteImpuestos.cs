using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaElectronica.CFDI33
{
    public partial class ComprobanteImpuestos
    {
        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos retenidos que se desprenden de los conceptos expresados en el comprobante fiscal digital por Internet. No se permiten valores negativos. Es requerido cuando en los conceptos se registren impuestos retenidos
        /// </summary>
        [XmlIgnore]
        public t_Importe TotalImpuestosRetenidos
        {
            set
            {
                _totalImpuestosRetenidos = value;
                sTotalImpuestosRetenidosSpecified = true;
            }
            get { return _totalImpuestosRetenidos; }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos trasladados que se desprenden de los conceptos expresados en el comprobante fiscal digital por Internet. No se permiten valores negativos. Es requerido cuando en los conceptos se registren impuestos trasladados.
        /// </summary>
        [XmlIgnore]
        public t_Importe TotalImpuestosTrasladados
        {
            set
            {
                _totalImpuestosTrasladados = value;
                sTotalImpuestosTrasladadosSpecified = true;
            }
            get { return _totalImpuestosTrasladados; }
        }
    }
}
