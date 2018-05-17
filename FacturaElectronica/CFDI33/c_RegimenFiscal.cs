using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_RegimenFiscal
    {

        /// <summary>
        /// General de Ley Personas Morales
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("601")]
        [StringValue("601")]
        RegimenFiscal601 = 601,

        /// <summary>
        /// Personas Morales con Fines no Lucrativos
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("603")]
        [StringValue("603")]
        RegimenFiscal603 = 603,

        /// <summary>
        /// Sueldos y Salarios e Ingresos Asimilados a Salarios
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("605")]
        [StringValue("605")]
        RegimenFiscal605 = 605,

        /// <summary>
        /// Arrendamiento
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("606")]
        [StringValue("606")]
        RegimenFiscal606 = 606,

        /// <summary>
        /// Demás ingresos
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("608")]
        [StringValue("608")]
        RegimenFiscal608 = 608,

        /// <summary>
        /// Consolidación
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("609")]
        [StringValue("609")]
        RegimenFiscal609 = 609,

        /// <summary>
        /// Residentes en el Extranjero sin Establecimiento Permanente en México
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("610")]
        [StringValue("610")]
        RegimenFiscal610 = 610,

        /// <summary>
        /// Ingresos por Dividendos (socios y accionistas)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("611")]
        [StringValue("611")]
        RegimenFiscal611 = 611,

        /// <summary>
        /// Personas Físicas con Actividades Empresariales y Profesionales
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("612")]
        [StringValue("612")]
        RegimenFiscal612 = 612,

        /// <summary>
        /// Ingresos por intereses
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("614")]
        [StringValue("614")]
        RegimenFiscal614 = 614,

        /// <summary>
        /// Sin obligaciones fiscales
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("616")]
        [StringValue("616")]
        RegimenFiscal616 = 616,

        /// <summary>
        /// Sociedades Cooperativas de Producción que optan por diferir sus ingresos
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("620")]
        [StringValue("620")]
        RegimenFiscal620 = 620,

        /// <summary>
        /// Incorporación Fiscal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("621")]
        [StringValue("621")]
        RegimenFiscal621 = 621,

        /// <summary>
        /// Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("622")]
        [StringValue("622")]
        RegimenFiscal622 = 622,

        /// <summary>
        /// Opcional para Grupos de Sociedades
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("623")]
        [StringValue("623")]
        RegimenFiscal623 = 623,

        /// <summary>
        /// Coordinados
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("624")]
        [StringValue("624")]
        RegimenFiscal624 = 624,

        /// <summary>
        /// Hidrocarburos
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("628")]
        [StringValue("628")]
        RegimenFiscal628 = 628,

        /// <summary>
        /// Régimen de Enajenación o Adquisición de Bienes
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("607")]
        [StringValue("607")]
        RegimenFiscal607 = 607,

        /// <summary>
        /// De los Regímenes Fiscales Preferentes y de las Empresas Multinacionales
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("629")]
        [StringValue("629")]
        RegimenFiscal629 = 629,

        /// <summary>
        /// Enajenación de acciones en bolsa de valores
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("630")]
        [StringValue("630")]
        RegimenFiscal630 = 630,

        /// <summary>
        /// Régimen de los ingresos por obtención de premios
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("615")]
        [StringValue("615")]
        RegimenFiscal615 = 615
    }

}
