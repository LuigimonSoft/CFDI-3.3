
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
    public enum c_TipoRegimen
    {

        [System.Xml.Serialization.XmlEnumAttribute("03")]
        TipoRegimen03=3,

        [System.Xml.Serialization.XmlEnumAttribute("02")]
        TipoRegimen02=2,

        [System.Xml.Serialization.XmlEnumAttribute("04")]
        TipoRegimen04=4,

        [System.Xml.Serialization.XmlEnumAttribute("05")]
        TipoRegimen05=5,

        [System.Xml.Serialization.XmlEnumAttribute("06")]
        TipoRegimen06=6,

        [System.Xml.Serialization.XmlEnumAttribute("07")]
        TipoRegimen07=7,

        [System.Xml.Serialization.XmlEnumAttribute("08")]
        TipoRegimen08=8,

        [System.Xml.Serialization.XmlEnumAttribute("09")]
        TipoRegimen09=9,

        [System.Xml.Serialization.XmlEnumAttribute("10")]
        TipoRegimen10=10,

        [System.Xml.Serialization.XmlEnumAttribute("11")]
        TipoRegimen11=11,

        [System.Xml.Serialization.XmlEnumAttribute("12")]
        TipoRegimen12=12,

        [System.Xml.Serialization.XmlEnumAttribute("13")]
        TipoRegimen13=13,

        [System.Xml.Serialization.XmlEnumAttribute("99")]
        TipoRegimen99=99,
    }
}

