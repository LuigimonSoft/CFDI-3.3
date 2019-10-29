
namespace FacturaElectronica.CFDI33.Complementos.Nomina12
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    using System.Xml;
    using System.Collections.Generic;

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
    public enum c_PeriodicidadPago
    {

        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Periodo01 = 1,

        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Periodo02,

        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Periodo03,

        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Periodo04,

        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Periodo05,

        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Periodo06,

        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Periodo07,

        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Periodo08,

        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Periodo09,

        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Periodo10,

        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Periodo99 = 99,
    }
}

