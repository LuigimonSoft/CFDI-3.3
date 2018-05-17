using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaElectronica.CFDI33
{
    public partial class ComprobanteConcepto
    {
        /// <summary>
        /// Atributo requerido para precisar el importe total de los bienes o servicios del presente concepto. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario expresado en el concepto. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe Importe { set; get; }


        /// <summary>
        /// Atributo opcional para representar el importe de los descuentos aplicables al concepto. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe Descuento {
            set
            {
                _descuento = value;
                sDescuentoSpecified = true;
            }
            get { return _descuento; } }

        /// <summary>
        /// Atributo requerido para precisar el valor o precio unitario del bien o servicio cubierto por el presente concepto.
        /// </summary>
        [XmlIgnore]
        public t_Importe ValorUnitario { set; get; }

        [XmlIgnore]
        public ComplementosConceptos.PorCuentadeTerceros Terceros { set; get; }

    }
}
