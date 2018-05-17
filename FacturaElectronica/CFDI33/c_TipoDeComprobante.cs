using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_TipoDeComprobante
    {
        /// <summary>
        /// Ingreso
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("I")]
        [StringValue("I")]
        I,

        /// <summary>
        /// Egreso
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E")]
        [StringValue("E")]
        E,

        /// <summary>
        /// Traslado
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("T")]
        [StringValue("T")]
        T,

        /// <summary>
        /// Nómina
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N")]
        [StringValue("N")]
        N,

        /// <summary>
        /// Pago
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P")]
        [StringValue("P")]
        P,
    }


}
