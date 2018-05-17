using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_TasaOCuota
    {
        /// <summary>
        /// group
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("0.000000")]
        [StringValue("0.000000")]
        TasaOCuota_0=0,

        [System.Xml.Serialization.XmlEnumAttribute("0.160000")]
        [StringValue("0.160000")]
        TasaOCuota_16 = 16,

        [System.Xml.Serialization.XmlEnumAttribute("0.265000")]
        [StringValue("0.265000")]
        TasaOCuota_265 = 265,

        [System.Xml.Serialization.XmlEnumAttribute("0.300000")]
        [StringValue("0.300000")]
        TasaOCuota_30 = 30,

        [System.Xml.Serialization.XmlEnumAttribute("0.530000")]
        [StringValue("0.530000")]
        TasaOCuota_53 = 53,

        [System.Xml.Serialization.XmlEnumAttribute("0.500000")]
        [StringValue("0.500000")]
        TasaOCuota_50 = 50,

        [System.Xml.Serialization.XmlEnumAttribute("1.600000")]
        [StringValue("1.600000")]
        TasaOCuota_160 = 160,

        [System.Xml.Serialization.XmlEnumAttribute("0.304000")]
        [StringValue("0.304000")]
        TasaOCuota_304 = 304,

        [System.Xml.Serialization.XmlEnumAttribute("0.350000")]
        [StringValue("0.350000")]
        TasaOCuota_350 = 350,

        [System.Xml.Serialization.XmlEnumAttribute("0.059100")]
        [StringValue("0.059100")]
        TasaOCuota_0591 = 0591,

        [System.Xml.Serialization.XmlEnumAttribute("3.000000")]
        [StringValue("3.000000")]
        TasaOCuota_3 = 3,

        [System.Xml.Serialization.XmlEnumAttribute("0.298800")]
        [StringValue("0.298800")]
        TasaOCuota_2988 = 2988
    }
}
