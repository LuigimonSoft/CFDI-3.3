using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_TipoFactor
    {
        /// <summary>
        /// Tasa
        /// </summary>
        [StringValue("Tasa")]
        [System.Xml.Serialization.XmlEnumAttribute("Tasa")]
        Tasa,

        /// <summary>
        /// Cuota
        /// </summary>
        [StringValue("Cuota")]
        [System.Xml.Serialization.XmlEnumAttribute("Cuota")]
        Cuota,

        /// <summary>
        /// Exento
        /// </summary>
        [StringValue("Exento")]
        [System.Xml.Serialization.XmlEnumAttribute("Exento")]
        Exento,
    }

}
