using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_TipoRelacion
    {
        /// <summary>
        /// Nota de crédito de los documentos relacionados
        /// </summary>
        [StringValue("01")]
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        TipoRelacion_01=1,

        /// <summary>
        /// Nota de débito de los documentos relacionados
        /// </summary>
        [StringValue("02")]
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        TipoRelacion_02,

        /// <summary>
        /// Devolución de mercancía sobre facturas o traslados previos
        /// </summary>
        [StringValue("03")]
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        TipoRelacion_03,

        /// <summary>
        /// Sustitución de los CFDI previos
        /// </summary>
        [StringValue("04")]
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        TipoRelacion_04,

        /// <summary>
        /// Traslados de mercancias facturados previamente
        /// </summary>
        [StringValue("05")]
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        TipoRelacion_05,

        /// <summary>
        /// Factura generada por los traslados previos
        /// </summary>
        [StringValue("06")]
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        TipoRelacion_06,
    }

}
