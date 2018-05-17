using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_Impuesto
    {
        /// <summary>
        /// ISR
        /// </summary>
        [StringValue("ISR")]
        [System.Xml.Serialization.XmlEnumAttribute("001")]
        ISR=1,

        /// <summary>
        /// IVA
        /// </summary>
        [StringValue("IVA")]
        [System.Xml.Serialization.XmlEnumAttribute("002")]
        IVA,

        /// <summary>
        /// IEPS
        /// </summary>
        [StringValue("IEPS")]
        [System.Xml.Serialization.XmlEnumAttribute("003")]
        IEPS,
    }

}
