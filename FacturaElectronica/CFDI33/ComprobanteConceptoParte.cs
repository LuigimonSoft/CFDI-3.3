using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaElectronica.CFDI33
{
    public partial class ComprobanteConceptoParte
    {
        /// <summary>
        /// Atributo opcional para precisar el valor o precio unitario del bien o servicio cubierto por la presente parte. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe ValorUnitario { set; get; }

        /// <summary>
        /// Atributo opcional para precisar el importe total de los bienes o servicios de la presente parte. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario expresado en la parte. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe Importe { set; get; }
    }
}
