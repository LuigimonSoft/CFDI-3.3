using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_MetodoPago
    {
        /// <summary>
        /// Pago en una sola exhibición
        /// </summary>
        [StringValue("PUE")]
        [System.Xml.Serialization.XmlEnumAttribute("PUE")]
        PUE,

        /// <summary>
        /// Pago inicial y parcialidades
        /// </summary>
        [StringValue("PIP")]
        [System.Xml.Serialization.XmlEnumAttribute("PIP")]
        PIP,

        /// <summary>
        /// Pago en parcialidades o diferido
        /// </summary>
        [StringValue("PPD")]
        [System.Xml.Serialization.XmlEnumAttribute("PPD")]
        PPD,
    }
}
